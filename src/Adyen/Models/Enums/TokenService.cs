using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The name of the token service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TokenService>))]
public sealed record TokenService : OpenStringEnum<TokenService>
{
    private TokenService(string value) : base(value)
    {
    }

    public static readonly TokenService Visatokenservice = new("VISATOKENSERVICE");

    public static readonly TokenService Mctokenservice = new("MCTOKENSERVICE");

    public static readonly TokenService Amextokenservice = new("AMEXTOKENSERVICE");

    public static readonly TokenService TokenSharing = new("TOKEN_SHARING");

    public TResult Match<TResult>(Func<TResult> onVisatokenservice,
        Func<TResult> onMctokenservice,
        Func<TResult> onAmextokenservice,
        Func<TResult> onTokenSharing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Visatokenservice => onVisatokenservice(),
            _ when this == Mctokenservice => onMctokenservice(),
            _ when this == Amextokenservice => onAmextokenservice(),
            _ when this == TokenSharing => onTokenSharing(),
            _ => otherwise(Value)
        };

    public void Match(Action onVisatokenservice,
        Action onMctokenservice,
        Action onAmextokenservice,
        Action onTokenSharing,
        Action<string> otherwise)
    {
        if (this == Visatokenservice) onVisatokenservice();
        else if (this == Mctokenservice) onMctokenservice();
        else if (this == Amextokenservice) onAmextokenservice();
        else if (this == TokenSharing) onTokenSharing();
        else otherwise(Value);
    }
}
