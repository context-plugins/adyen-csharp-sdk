using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The current status of the grant. Possible values: <b>Pending</b>, <b>Active</b>, <b>Repaid</b>, <b>WrittenOff</b>, <b>Failed</b>, <b>Revoked</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status14>))]
public sealed record Status14 : OpenStringEnum<Status14>
{
    private Status14(string value) : base(value)
    {
    }

    public static readonly Status14 Pending = new("Pending");

    public static readonly Status14 Active = new("Active");

    public static readonly Status14 Repaid = new("Repaid");

    public static readonly Status14 Failed = new("Failed");

    public static readonly Status14 WrittenOff = new("WrittenOff");

    public static readonly Status14 Revoked = new("Revoked");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onActive,
        Func<TResult> onRepaid,
        Func<TResult> onFailed,
        Func<TResult> onWrittenOff,
        Func<TResult> onRevoked,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Active => onActive(),
            _ when this == Repaid => onRepaid(),
            _ when this == Failed => onFailed(),
            _ when this == WrittenOff => onWrittenOff(),
            _ when this == Revoked => onRevoked(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onActive,
        Action onRepaid,
        Action onFailed,
        Action onWrittenOff,
        Action onRevoked,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Active) onActive();
        else if (this == Repaid) onRepaid();
        else if (this == Failed) onFailed();
        else if (this == WrittenOff) onWrittenOff();
        else if (this == Revoked) onRevoked();
        else otherwise(Value);
    }
}
