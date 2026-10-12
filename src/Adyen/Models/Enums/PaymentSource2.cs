using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The source used to obtain the payload. Possible values: <c>qr</c>, <c>redirect</c>, and <c>pushNotification</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentSource2>))]
public sealed record PaymentSource2 : OpenStringEnum<PaymentSource2>
{
    private PaymentSource2(string value) : base(value)
    {
    }

    public static readonly PaymentSource2 Redirect = new("redirect");

    public static readonly PaymentSource2 Qr = new("qr");

    public static readonly PaymentSource2 PushNotification = new("pushNotification");

    public TResult Match<TResult>(Func<TResult> onRedirect,
        Func<TResult> onQr,
        Func<TResult> onPushNotification,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Redirect => onRedirect(),
            _ when this == Qr => onQr(),
            _ when this == PushNotification => onPushNotification(),
            _ => otherwise(Value)
        };

    public void Match(Action onRedirect, Action onQr, Action onPushNotification, Action<string> otherwise)
    {
        if (this == Redirect) onRedirect();
        else if (this == Qr) onQr();
        else if (this == PushNotification) onPushNotification();
        else otherwise(Value);
    }
}
