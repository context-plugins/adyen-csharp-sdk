using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if the modification request has been received for processing.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseModel>))]
public sealed record ResponseModel : StringEnum<ResponseModel>
{
    private ResponseModel(string value) : base(value)
    {
    }

    public static readonly ResponseModel CaptureReceived = new("[capture-received]");

    public static readonly ResponseModel CancelReceived = new("[cancel-received]");

    public static readonly ResponseModel RefundReceived = new("[refund-received]");

    public static readonly ResponseModel CancelOrRefundReceived = new("[cancelOrRefund-received]");

    public static readonly ResponseModel AdjustAuthorisationReceived = new("[adjustAuthorisation-received]");

    public static readonly ResponseModel DonationReceived = new("[donation-received]");

    public static readonly ResponseModel TechnicalCancelReceived = new("[technical-cancel-received]");

    public static readonly ResponseModel VoidPendingRefundReceived = new("[voidPendingRefund-received]");

    public static readonly ResponseModel Authorised = new("Authorised");

    public static readonly ResponseModel Refused = new("Refused");

    public static readonly ResponseModel Error = new("Error");

    public static ResponseModel FromValue(string value) => FromValueCore(value);
}
