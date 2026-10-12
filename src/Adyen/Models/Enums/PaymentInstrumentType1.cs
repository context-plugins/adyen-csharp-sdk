using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Card</b>
/// * <b>Check</b>
/// * <b>Mobile</b>
/// * <b>StoredValue</b>
/// * <b>Cash</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInstrumentType1>))]
public sealed record PaymentInstrumentType1 : OpenStringEnum<PaymentInstrumentType1>
{
    private PaymentInstrumentType1(string value) : base(value)
    {
    }

    public static readonly PaymentInstrumentType1 Card = new("Card");

    public static readonly PaymentInstrumentType1 Check = new("Check");

    public static readonly PaymentInstrumentType1 Mobile = new("Mobile");

    public static readonly PaymentInstrumentType1 StoredValue = new("StoredValue");

    public static readonly PaymentInstrumentType1 Cash = new("Cash");

    public TResult Match<TResult>(Func<TResult> onCard,
        Func<TResult> onCheck,
        Func<TResult> onMobile,
        Func<TResult> onStoredValue,
        Func<TResult> onCash,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Card => onCard(),
            _ when this == Check => onCheck(),
            _ when this == Mobile => onMobile(),
            _ when this == StoredValue => onStoredValue(),
            _ when this == Cash => onCash(),
            _ => otherwise(Value)
        };

    public void Match(Action onCard,
        Action onCheck,
        Action onMobile,
        Action onStoredValue,
        Action onCash,
        Action<string> otherwise)
    {
        if (this == Card) onCard();
        else if (this == Check) onCheck();
        else if (this == Mobile) onMobile();
        else if (this == StoredValue) onStoredValue();
        else if (this == Cash) onCash();
        else otherwise(Value);
    }
}
