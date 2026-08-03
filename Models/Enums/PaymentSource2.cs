using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The source used to obtain the payload. Possible values: <c>qr</c>, <c>redirect</c>, and <c>pushNotification</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentSource2>))]
public sealed record PaymentSource2 : StringEnum<PaymentSource2>
{
    private PaymentSource2(string value) : base(value)
    {
    }

    public static readonly PaymentSource2 Redirect = new("redirect");

    public static readonly PaymentSource2 Qr = new("qr");

    public static readonly PaymentSource2 PushNotification = new("pushNotification");

    public static PaymentSource2 FromValue(string value) => FromValueCore(value);
}
