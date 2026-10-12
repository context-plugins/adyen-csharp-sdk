using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Status of the payment link. Possible values:
/// * <b>active</b>: The link can be used to make payments.
/// * <b>expired</b>: The expiry date for the payment link has passed. Shoppers can no longer use the link to make payments.
/// * <b>completed</b>: The shopper completed the payment.
/// * <b>paymentPending</b>: The shopper is in the process of making the payment. Applies to payment methods with an asynchronous flow.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status3>))]
public sealed record Status3 : OpenStringEnum<Status3>
{
    private Status3(string value) : base(value)
    {
    }

    public static readonly Status3 Active = new("active");

    public static readonly Status3 Completed = new("completed");

    public static readonly Status3 Expired = new("expired");

    public static readonly Status3 Paid = new("paid");

    public static readonly Status3 PaymentPending = new("paymentPending");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onCompleted,
        Func<TResult> onExpired,
        Func<TResult> onPaid,
        Func<TResult> onPaymentPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Completed => onCompleted(),
            _ when this == Expired => onExpired(),
            _ when this == Paid => onPaid(),
            _ when this == PaymentPending => onPaymentPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive,
        Action onCompleted,
        Action onExpired,
        Action onPaid,
        Action onPaymentPending,
        Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Completed) onCompleted();
        else if (this == Expired) onExpired();
        else if (this == Paid) onPaid();
        else if (this == PaymentPending) onPaymentPending();
        else otherwise(Value);
    }
}
