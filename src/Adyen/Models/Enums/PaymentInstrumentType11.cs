using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of payment instrument.
/// Possible values:
/// * <b>Card</b>
/// * <b>Cash</b>
/// * <b>Check</b>
/// * <b>Mobile</b>
/// * <b>StoredValue</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInstrumentType11>))]
public sealed record PaymentInstrumentType11 : OpenStringEnum<PaymentInstrumentType11>
{
    private PaymentInstrumentType11(string value) : base(value)
    {
    }

    public static readonly PaymentInstrumentType11 Card = new("Card");

    public static readonly PaymentInstrumentType11 Check = new("Check");

    public static readonly PaymentInstrumentType11 Mobile = new("Mobile");

    public static readonly PaymentInstrumentType11 StoredValue = new("StoredValue");

    public static readonly PaymentInstrumentType11 Cash = new("Cash");

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
