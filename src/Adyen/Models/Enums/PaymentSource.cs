using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PaymentSource>))]
public sealed record PaymentSource : OpenStringEnum<PaymentSource>
{
    private PaymentSource(string value) : base(value)
    {
    }

    public static readonly PaymentSource Redirect = new("redirect");

    public static readonly PaymentSource Qr = new("qr");

    public static readonly PaymentSource PushNotification = new("pushNotification");

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
