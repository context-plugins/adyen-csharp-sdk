using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the type of request to which the rule applies. If not provided, by default, this is set to <b>authorization</b>.
/// <para>
/// Possible values: <b>authorization</b>, <b>authentication</b>, <b>tokenization</b>, <b>bankTransfer</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RequestType>))]
public sealed record RequestType : OpenStringEnum<RequestType>
{
    private RequestType(string value) : base(value)
    {
    }

    public static readonly RequestType Authentication = new("authentication");

    public static readonly RequestType Authorization = new("authorization");

    public static readonly RequestType BankTransfer = new("bankTransfer");

    public static readonly RequestType Tokenization = new("tokenization");

    public TResult Match<TResult>(Func<TResult> onAuthentication,
        Func<TResult> onAuthorization,
        Func<TResult> onBankTransfer,
        Func<TResult> onTokenization,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Authentication => onAuthentication(),
            _ when this == Authorization => onAuthorization(),
            _ when this == BankTransfer => onBankTransfer(),
            _ when this == Tokenization => onTokenization(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuthentication,
        Action onAuthorization,
        Action onBankTransfer,
        Action onTokenization,
        Action<string> otherwise)
    {
        if (this == Authentication) onAuthentication();
        else if (this == Authorization) onAuthorization();
        else if (this == BankTransfer) onBankTransfer();
        else if (this == Tokenization) onTokenization();
        else otherwise(Value);
    }
}
