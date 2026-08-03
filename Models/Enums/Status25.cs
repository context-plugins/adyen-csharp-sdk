using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transfer event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status25>))]
public sealed record Status25 : StringEnum<Status25>
{
    private Status25(string value) : base(value)
    {
    }

    public static readonly Status25 ApprovalPending = new("approvalPending");

    public static readonly Status25 AtmWithdrawal = new("atmWithdrawal");

    public static readonly Status25 AtmWithdrawalReversalPending = new("atmWithdrawalReversalPending");

    public static readonly Status25 AtmWithdrawalReversed = new("atmWithdrawalReversed");

    public static readonly Status25 AuthAdjustmentAuthorised = new("authAdjustmentAuthorised");

    public static readonly Status25 AuthAdjustmentError = new("authAdjustmentError");

    public static readonly Status25 AuthAdjustmentRefused = new("authAdjustmentRefused");

    public static readonly Status25 Authorised = new("authorised");

    public static readonly Status25 BankTransfer = new("bankTransfer");

    public static readonly Status25 BankTransferPending = new("bankTransferPending");

    public static readonly Status25 Booked = new("booked");

    public static readonly Status25 BookingPending = new("bookingPending");

    public static readonly Status25 Cancelled = new("cancelled");

    public static readonly Status25 CapturePending = new("capturePending");

    public static readonly Status25 CaptureReversalPending = new("captureReversalPending");

    public static readonly Status25 CaptureReversed = new("captureReversed");

    public static readonly Status25 Captured = new("captured");

    public static readonly Status25 CapturedExternally = new("capturedExternally");

    public static readonly Status25 Chargeback = new("chargeback");

    public static readonly Status25 ChargebackExternally = new("chargebackExternally");

    public static readonly Status25 ChargebackPending = new("chargebackPending");

    public static readonly Status25 ChargebackReversalPending = new("chargebackReversalPending");

    public static readonly Status25 ChargebackReversed = new("chargebackReversed");

    public static readonly Status25 Credited = new("credited");

    public static readonly Status25 DepositCorrection = new("depositCorrection");

    public static readonly Status25 DepositCorrectionPending = new("depositCorrectionPending");

    public static readonly Status25 Dispute = new("dispute");

    public static readonly Status25 DisputeClosed = new("disputeClosed");

    public static readonly Status25 DisputeExpired = new("disputeExpired");

    public static readonly Status25 DisputeNeedsReview = new("disputeNeedsReview");

    public static readonly Status25 Error = new("error");

    public static readonly Status25 Expired = new("expired");

    public static readonly Status25 Failed = new("failed");

    public static readonly Status25 Fee = new("fee");

    public static readonly Status25 FeePending = new("feePending");

    public static readonly Status25 InterchangeAdjusted = new("interchangeAdjusted");

    public static readonly Status25 InternalTransfer = new("internalTransfer");

    public static readonly Status25 InternalTransferPending = new("internalTransferPending");

    public static readonly Status25 InvoiceDeduction = new("invoiceDeduction");

    public static readonly Status25 InvoiceDeductionPending = new("invoiceDeductionPending");

    public static readonly Status25 ManualCorrectionPending = new("manualCorrectionPending");

    public static readonly Status25 ManuallyCorrected = new("manuallyCorrected");

    public static readonly Status25 MatchedStatement = new("matchedStatement");

    public static readonly Status25 MatchedStatementPending = new("matchedStatementPending");

    public static readonly Status25 MerchantPayin = new("merchantPayin");

    public static readonly Status25 MerchantPayinPending = new("merchantPayinPending");

    public static readonly Status25 MerchantPayinReversed = new("merchantPayinReversed");

    public static readonly Status25 MerchantPayinReversedPending = new("merchantPayinReversedPending");

    public static readonly Status25 MiscCost = new("miscCost");

    public static readonly Status25 MiscCostPending = new("miscCostPending");

    public static readonly Status25 PaymentCost = new("paymentCost");

    public static readonly Status25 PaymentCostPending = new("paymentCostPending");

    public static readonly Status25 Pending = new("pending");

    public static readonly Status25 PendingApproval = new("pendingApproval");

    public static readonly Status25 PendingExecution = new("pendingExecution");

    public static readonly Status25 Received = new("received");

    public static readonly Status25 RefundPending = new("refundPending");

    public static readonly Status25 RefundReversalPending = new("refundReversalPending");

    public static readonly Status25 RefundReversed = new("refundReversed");

    public static readonly Status25 Refunded = new("refunded");

    public static readonly Status25 RefundedExternally = new("refundedExternally");

    public static readonly Status25 Refused = new("refused");

    public static readonly Status25 Rejected = new("rejected");

    public static readonly Status25 ReserveAdjustment = new("reserveAdjustment");

    public static readonly Status25 ReserveAdjustmentPending = new("reserveAdjustmentPending");

    public static readonly Status25 Returned = new("returned");

    public static readonly Status25 Reversed = new("reversed");

    public static readonly Status25 SecondChargeback = new("secondChargeback");

    public static readonly Status25 SecondChargebackPending = new("secondChargebackPending");

    public static readonly Status25 Undefined = new("undefined");

    public static Status25 FromValue(string value) => FromValueCore(value);
}
