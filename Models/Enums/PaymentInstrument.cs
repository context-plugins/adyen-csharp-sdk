using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Sets the allowed payment instrument for Pay at table transactions.  Can be: <b>cash</b> or <b>card</b>. If not set, the terminal presents both options.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInstrument>))]
public sealed record PaymentInstrument : StringEnum<PaymentInstrument>
{
    private PaymentInstrument(string value) : base(value)
    {
    }

    public static readonly PaymentInstrument Cash = new("Cash");

    public static readonly PaymentInstrument Card = new("Card");

    public static PaymentInstrument FromValue(string value) => FromValueCore(value);
}
