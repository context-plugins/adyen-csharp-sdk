using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PaymentSource>))]
public sealed record PaymentSource : StringEnum<PaymentSource>
{
    private PaymentSource(string value) : base(value)
    {
    }

    public static readonly PaymentSource Redirect = new("redirect");

    public static readonly PaymentSource Qr = new("qr");

    public static readonly PaymentSource PushNotification = new("pushNotification");

    public static PaymentSource FromValue(string value) => FromValueCore(value);
}
