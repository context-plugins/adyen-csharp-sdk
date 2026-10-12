using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if the modification request has been received for processing.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseEnum>))]
public sealed record ResponseEnum : OpenStringEnum<ResponseEnum>
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

    public TResult Match<TResult>(Func<TResult> onCaptureReceived,
        Func<TResult> onCancelReceived,
        Func<TResult> onRefundReceived,
        Func<TResult> onCancelOrRefundReceived,
        Func<TResult> onAdjustAuthorisationReceived,
        Func<TResult> onDonationReceived,
        Func<TResult> onTechnicalCancelReceived,
        Func<TResult> onVoidPendingRefundReceived,
        Func<TResult> onAuthorised,
        Func<TResult> onRefused,
        Func<TResult> onError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CaptureReceived => onCaptureReceived(),
            _ when this == CancelReceived => onCancelReceived(),
            _ when this == RefundReceived => onRefundReceived(),
            _ when this == CancelOrRefundReceived => onCancelOrRefundReceived(),
            _ when this == AdjustAuthorisationReceived => onAdjustAuthorisationReceived(),
            _ when this == DonationReceived => onDonationReceived(),
            _ when this == TechnicalCancelReceived => onTechnicalCancelReceived(),
            _ when this == VoidPendingRefundReceived => onVoidPendingRefundReceived(),
            _ when this == Authorised => onAuthorised(),
            _ when this == Refused => onRefused(),
            _ when this == Error => onError(),
            _ => otherwise(Value)
        };

    public void Match(Action onCaptureReceived,
        Action onCancelReceived,
        Action onRefundReceived,
        Action onCancelOrRefundReceived,
        Action onAdjustAuthorisationReceived,
        Action onDonationReceived,
        Action onTechnicalCancelReceived,
        Action onVoidPendingRefundReceived,
        Action onAuthorised,
        Action onRefused,
        Action onError,
        Action<string> otherwise)
    {
        if (this == CaptureReceived) onCaptureReceived();
        else if (this == CancelReceived) onCancelReceived();
        else if (this == RefundReceived) onRefundReceived();
        else if (this == CancelOrRefundReceived) onCancelOrRefundReceived();
        else if (this == AdjustAuthorisationReceived) onAdjustAuthorisationReceived();
        else if (this == DonationReceived) onDonationReceived();
        else if (this == TechnicalCancelReceived) onTechnicalCancelReceived();
        else if (this == VoidPendingRefundReceived) onVoidPendingRefundReceived();
        else if (this == Authorised) onAuthorised();
        else if (this == Refused) onRefused();
        else if (this == Error) onError();
        else otherwise(Value);
    }
}
