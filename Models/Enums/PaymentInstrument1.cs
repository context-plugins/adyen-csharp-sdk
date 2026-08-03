using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Sets the allowed payment instrument for Pay at table transactions.  Can be: <b>cash</b> or <b>card</b>. If not set, the terminal presents both options.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInstrument1>))]
public sealed record PaymentInstrument1 : StringEnum<PaymentInstrument1>
{
    private PaymentInstrument1(string value) : base(value)
    {
    }

    public static readonly PaymentInstrument1 Cash = new("Cash");

    public static readonly PaymentInstrument1 Card = new("Card");

    public static PaymentInstrument1 FromValue(string value) => FromValueCore(value);
}
