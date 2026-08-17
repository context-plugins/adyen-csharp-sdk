using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transfer event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status24>))]
public sealed record Status24 : StringEnum<Status24>
{
    private Status24(string value) : base(value)
    {
    }

    public static readonly Status24 ApprovalPending = new("approvalPending");

    public static readonly Status24 AtmWithdrawal = new("atmWithdrawal");

    public static readonly Status24 AtmWithdrawalReversalPending = new("atmWithdrawalReversalPending");

    public static readonly Status24 AtmWithdrawalReversed = new("atmWithdrawalReversed");

    public static readonly Status24 AuthAdjustmentAuthorised = new("authAdjustmentAuthorised");

    public static readonly Status24 AuthAdjustmentError = new("authAdjustmentError");

    public static readonly Status24 AuthAdjustmentRefused = new("authAdjustmentRefused");

    public static readonly Status24 Authorised = new("authorised");

    public static readonly Status24 BankTransfer = new("bankTransfer");

    public static readonly Status24 BankTransferPending = new("bankTransferPending");

    public static readonly Status24 Booked = new("booked");

    public static readonly Status24 BookingPending = new("bookingPending");

    public static readonly Status24 Cancelled = new("cancelled");

    public static readonly Status24 CapturePending = new("capturePending");

    public static readonly Status24 CaptureReversalPending = new("captureReversalPending");

    public static readonly Status24 CaptureReversed = new("captureReversed");

    public static readonly Status24 Captured = new("captured");

    public static readonly Status24 CapturedExternally = new("capturedExternally");

    public static readonly Status24 Chargeback = new("chargeback");

    public static readonly Status24 ChargebackExternally = new("chargebackExternally");

    public static readonly Status24 ChargebackPending = new("chargebackPending");

    public static readonly Status24 ChargebackReversalPending = new("chargebackReversalPending");

    public static readonly Status24 ChargebackReversed = new("chargebackReversed");

    public static readonly Status24 Credited = new("credited");

    public static readonly Status24 DepositCorrection = new("depositCorrection");

    public static readonly Status24 DepositCorrectionPending = new("depositCorrectionPending");

    public static readonly Status24 Dispute = new("dispute");

    public static readonly Status24 DisputeClosed = new("disputeClosed");

    public static readonly Status24 DisputeExpired = new("disputeExpired");

    public static readonly Status24 DisputeNeedsReview = new("disputeNeedsReview");

    public static readonly Status24 Error = new("error");

    public static readonly Status24 Expired = new("expired");

    public static readonly Status24 Failed = new("failed");

    public static readonly Status24 Fee = new("fee");

    public static readonly Status24 FeePending = new("feePending");

    public static readonly Status24 InterchangeAdjusted = new("interchangeAdjusted");

    public static readonly Status24 InternalTransfer = new("internalTransfer");

    public static readonly Status24 InternalTransferPending = new("internalTransferPending");

    public static readonly Status24 InvoiceDeduction = new("invoiceDeduction");

    public static readonly Status24 InvoiceDeductionPending = new("invoiceDeductionPending");

    public static readonly Status24 ManualCorrectionPending = new("manualCorrectionPending");

    public static readonly Status24 ManuallyCorrected = new("manuallyCorrected");

    public static readonly Status24 MatchedStatement = new("matchedStatement");

    public static readonly Status24 MatchedStatementPending = new("matchedStatementPending");

    public static readonly Status24 MerchantPayin = new("merchantPayin");

    public static readonly Status24 MerchantPayinPending = new("merchantPayinPending");

    public static readonly Status24 MerchantPayinReversed = new("merchantPayinReversed");

    public static readonly Status24 MerchantPayinReversedPending = new("merchantPayinReversedPending");

    public static readonly Status24 MiscCost = new("miscCost");

    public static readonly Status24 MiscCostPending = new("miscCostPending");

    public static readonly Status24 PaymentCost = new("paymentCost");

    public static readonly Status24 PaymentCostPending = new("paymentCostPending");

    public static readonly Status24 Pending = new("pending");

    public static readonly Status24 PendingApproval = new("pendingApproval");

    public static readonly Status24 PendingExecution = new("pendingExecution");

    public static readonly Status24 Received = new("received");

    public static readonly Status24 RefundPending = new("refundPending");

    public static readonly Status24 RefundReversalPending = new("refundReversalPending");

    public static readonly Status24 RefundReversed = new("refundReversed");

    public static readonly Status24 Refunded = new("refunded");

    public static readonly Status24 RefundedExternally = new("refundedExternally");

    public static readonly Status24 Refused = new("refused");

    public static readonly Status24 Rejected = new("rejected");

    public static readonly Status24 ReserveAdjustment = new("reserveAdjustment");

    public static readonly Status24 ReserveAdjustmentPending = new("reserveAdjustmentPending");

    public static readonly Status24 Returned = new("returned");

    public static readonly Status24 Reversed = new("reversed");

    public static readonly Status24 SecondChargeback = new("secondChargeback");

    public static readonly Status24 SecondChargebackPending = new("secondChargebackPending");

    public static readonly Status24 Undefined = new("undefined");

    public static Status24 FromValue(string value) => FromValueCore(value);
}
