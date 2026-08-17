using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The sales channel used for the payment., The sales channel. Possible values: <b>Ecommerce</b>, <b>POS</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentFlow>))]
public sealed record PaymentFlow : StringEnum<PaymentFlow>
{
    private PaymentFlow(string value) : base(value)
    {
    }

    public static readonly PaymentFlow Ecommerce = new("Ecommerce");

    public static readonly PaymentFlow Pos = new("POS");

    public static PaymentFlow FromValue(string value) => FromValueCore(value);
}
