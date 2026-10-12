using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of Strong Customer Authentication (SCA). Possible values:
/// * <b>notPerformed</b>: the requester was unable to successfully authenticate the request using SCA, or has an SCA exemption.
/// * <b>pending</b>: the request is pending SCA authentication.
/// * <b>performed</b>: the request is successfully authenticated using SCA.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaStatus>))]
public sealed record ScaStatus : OpenStringEnum<ScaStatus>
{
    private ScaStatus(string value) : base(value)
    {
    }

    public static readonly ScaStatus NotPerformed = new("notPerformed");

    public static readonly ScaStatus Pending = new("pending");

    public static readonly ScaStatus Performed = new("performed");

    public TResult Match<TResult>(Func<TResult> onNotPerformed,
        Func<TResult> onPending,
        Func<TResult> onPerformed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotPerformed => onNotPerformed(),
            _ when this == Pending => onPending(),
            _ when this == Performed => onPerformed(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotPerformed, Action onPending, Action onPerformed, Action<string> otherwise)
    {
        if (this == NotPerformed) onNotPerformed();
        else if (this == Pending) onPending();
        else if (this == Performed) onPerformed();
        else otherwise(Value);
    }
}
