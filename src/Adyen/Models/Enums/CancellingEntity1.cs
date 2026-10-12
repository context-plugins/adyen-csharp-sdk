using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The party that initiated the cancellation of the transaction.
/// <para>
/// Possible values: <b>merchant</b>, <b>cardholder</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CancellingEntity1>))]
public sealed record CancellingEntity1 : OpenStringEnum<CancellingEntity1>
{
    private CancellingEntity1(string value) : base(value)
    {
    }

    public static readonly CancellingEntity1 Merchant = new("merchant");

    public static readonly CancellingEntity1 Cardholder = new("cardholder");

    public TResult Match<TResult>(Func<TResult> onMerchant,
        Func<TResult> onCardholder,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Merchant => onMerchant(),
            _ when this == Cardholder => onCardholder(),
            _ => otherwise(Value)
        };

    public void Match(Action onMerchant, Action onCardholder, Action<string> otherwise)
    {
        if (this == Merchant) onMerchant();
        else if (this == Cardholder) onCardholder();
        else otherwise(Value);
    }
}
