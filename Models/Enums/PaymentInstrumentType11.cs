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
public sealed record PaymentInstrumentType11 : StringEnum<PaymentInstrumentType11>
{
    private PaymentInstrumentType11(string value) : base(value)
    {
    }

    public static readonly PaymentInstrumentType11 Card = new("Card");

    public static readonly PaymentInstrumentType11 Check = new("Check");

    public static readonly PaymentInstrumentType11 Mobile = new("Mobile");

    public static readonly PaymentInstrumentType11 StoredValue = new("StoredValue");

    public static readonly PaymentInstrumentType11 Cash = new("Cash");

    public static PaymentInstrumentType11 FromValue(string value) => FromValueCore(value);
}
