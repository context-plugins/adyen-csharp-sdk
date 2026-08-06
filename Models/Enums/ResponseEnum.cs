using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if the modification request has been received for processing.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseEnum>))]
public sealed record ResponseEnum : StringEnum<ResponseEnum>
{
    private ResponseEnum(string value) : base(value)
    {
    }

    public static readonly ResponseEnum CaptureReceived = new("[capture-received]");

    public static readonly ResponseEnum CancelReceived = new("[cancel-received]");

    public static readonly ResponseEnum RefundReceived = new("[refund-received]");

    public static readonly ResponseEnum CancelOrRefundReceived = new("[cancelOrRefund-received]");

    public static readonly ResponseEnum AdjustAuthorisationReceived = new("[adjustAuthorisation-received]");

    public static readonly ResponseEnum DonationReceived = new("[donation-received]");

    public static readonly ResponseEnum TechnicalCancelReceived = new("[technical-cancel-received]");

    public static readonly ResponseEnum VoidPendingRefundReceived = new("[voidPendingRefund-received]");

    public static readonly ResponseEnum Authorised = new("Authorised");

    public static readonly ResponseEnum Refused = new("Refused");

    public static readonly ResponseEnum Error = new("Error");

    public static ResponseEnum FromValue(string value) => FromValueCore(value);
}
