using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the session. The status included in the response doesn't get updated. Don't make the request again to check for payment status updates.
/// <para>
/// Possible values:
/// * <b>completed</b>: the shopper completed the payment, and the payment was authorized.
/// * <b>paymentPending</b>: the shopper is in the process of making the payment. This applies to payment methods with an asynchronous flow, like voucher payments where the shopper completes the payment in a physical shop.
/// * <b>refused</b>: the session has been refused, because of too many refused payment attempts. The shopper can no longer complete the payment with this session.
/// * <b>canceled</b>: the shopper canceled the payment.
/// * <b>expired</b>: the session expired. The shopper can no longer complete the payment with this session. By default, the session expires one hour after it is created.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status5>))]
public sealed record Status5 : StringEnum<Status5>
{
    private Status5(string value) : base(value)
    {
    }

    public static readonly Status5 Active = new("active");

    public static readonly Status5 Canceled = new("canceled");

    public static readonly Status5 Completed = new("completed");

    public static readonly Status5 Expired = new("expired");

    public static readonly Status5 PaymentPending = new("paymentPending");

    public static readonly Status5 Refused = new("refused");

    public static Status5 FromValue(string value) => FromValueCore(value);
}
