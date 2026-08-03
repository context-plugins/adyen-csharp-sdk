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
[JsonConverter(typeof(StringEnumConverter<Status31>))]
public sealed record Status31 : StringEnum<Status31>
{
    private Status31(string value) : base(value)
    {
    }

    public static readonly Status31 Active = new("active");

    public static readonly Status31 Completed = new("completed");

    public static readonly Status31 Expired = new("expired");

    public static readonly Status31 Paid = new("paid");

    public static readonly Status31 PaymentPending = new("paymentPending");

    public static Status31 FromValue(string value) => FromValueCore(value);
}
