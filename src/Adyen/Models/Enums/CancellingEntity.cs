using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CancellingEntity>))]
public sealed record CancellingEntity : OpenStringEnum<CancellingEntity>
{
    private CancellingEntity(string value) : base(value)
    {
    }

    public static readonly CancellingEntity Merchant = new("merchant");

    public static readonly CancellingEntity Cardholder = new("cardholder");

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
