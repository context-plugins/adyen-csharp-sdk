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
public sealed record PaymentInstrumentType1 : StringEnum<PaymentInstrumentType1>
{
    private PaymentInstrumentType1(string value) : base(value)
    {
    }

    public static readonly PaymentInstrumentType1 Card = new("Card");

    public static readonly PaymentInstrumentType1 Check = new("Check");

    public static readonly PaymentInstrumentType1 Mobile = new("Mobile");

    public static readonly PaymentInstrumentType1 StoredValue = new("StoredValue");

    public static readonly PaymentInstrumentType1 Cash = new("Cash");

    public static PaymentInstrumentType1 FromValue(string value) => FromValueCore(value);
}
