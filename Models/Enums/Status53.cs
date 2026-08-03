using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of the transfer.
/// <para>
/// For example:
/// </para>
/// <list type="bullet">
///   <item><description><b>received</b>: an outgoing transfer request is created.</description></item>
///   <item><description><b>refused</b>: the transfer request is rejected by Adyen for one of the following reasons:
///     <list type="bullet">
///       <item><description>Transfer limit exceeded.</description></item>
///       <item><description>Transaction rule requirements violated.</description></item>
///     </list>
///   </description></item>
///   <item><description><b>authorised</b>: the transfer request is authorized and the funds are reserved.</description></item>
///   <item><description><b>booked</b>: the funds are deducted from your user's balance account.
///     <list type="bullet">
///       <item><description><b>failed</b>: the transfer is rejected by the counterparty's bank.</description></item>
///     </list>
///   </description></item>
///   <item><description><b>returned</b>: the transfer is returned by the counterparty's bank.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status53>))]
public sealed record Status53 : StringEnum<Status53>
{
    private Status53(string value) : base(value)
    {
    }

    public static readonly Status53 ApprovalPending = new("approvalPending");

    public static readonly Status53 AtmWithdrawal = new("atmWithdrawal");

    public static readonly Status53 AtmWithdrawalReversalPending = new("atmWithdrawalReversalPending");

    public static readonly Status53 AtmWithdrawalReversed = new("atmWithdrawalReversed");

    public static readonly Status53 AuthAdjustmentAuthorised = new("authAdjustmentAuthorised");

    public static readonly Status53 AuthAdjustmentError = new("authAdjustmentError");

    public static readonly Status53 AuthAdjustmentRefused = new("authAdjustmentRefused");

    public static readonly Status53 Authorised = new("authorised");

    public static readonly Status53 BankTransfer = new("bankTransfer");

    public static readonly Status53 BankTransferPending = new("bankTransferPending");

    public static readonly Status53 Booked = new("booked");

    public static readonly Status53 BookingPending = new("bookingPending");

    public static readonly Status53 Cancelled = new("cancelled");

    public static readonly Status53 CapturePending = new("capturePending");

    public static readonly Status53 CaptureReversalPending = new("captureReversalPending");

    public static readonly Status53 CaptureReversed = new("captureReversed");

    public static readonly Status53 Captured = new("captured");

    public static readonly Status53 CapturedExternally = new("capturedExternally");

    public static readonly Status53 Chargeback = new("chargeback");

    public static readonly Status53 ChargebackExternally = new("chargebackExternally");

    public static readonly Status53 ChargebackPending = new("chargebackPending");

    public static readonly Status53 ChargebackReversalPending = new("chargebackReversalPending");

    public static readonly Status53 ChargebackReversed = new("chargebackReversed");

    public static readonly Status53 Credited = new("credited");

    public static readonly Status53 DepositCorrection = new("depositCorrection");

    public static readonly Status53 DepositCorrectionPending = new("depositCorrectionPending");

    public static readonly Status53 Dispute = new("dispute");

    public static readonly Status53 DisputeClosed = new("disputeClosed");

    public static readonly Status53 DisputeExpired = new("disputeExpired");

    public static readonly Status53 DisputeNeedsReview = new("disputeNeedsReview");

    public static readonly Status53 Error = new("error");

    public static readonly Status53 Expired = new("expired");

    public static readonly Status53 Failed = new("failed");

    public static readonly Status53 Fee = new("fee");

    public static readonly Status53 FeePending = new("feePending");

    public static readonly Status53 InterchangeAdjusted = new("interchangeAdjusted");

    public static readonly Status53 InternalTransfer = new("internalTransfer");

    public static readonly Status53 InternalTransferPending = new("internalTransferPending");

    public static readonly Status53 InvoiceDeduction = new("invoiceDeduction");

    public static readonly Status53 InvoiceDeductionPending = new("invoiceDeductionPending");

    public static readonly Status53 ManualCorrectionPending = new("manualCorrectionPending");

    public static readonly Status53 ManuallyCorrected = new("manuallyCorrected");

    public static readonly Status53 MatchedStatement = new("matchedStatement");

    public static readonly Status53 MatchedStatementPending = new("matchedStatementPending");

    public static readonly Status53 MerchantPayin = new("merchantPayin");

    public static readonly Status53 MerchantPayinPending = new("merchantPayinPending");

    public static readonly Status53 MerchantPayinReversed = new("merchantPayinReversed");

    public static readonly Status53 MerchantPayinReversedPending = new("merchantPayinReversedPending");

    public static readonly Status53 MiscCost = new("miscCost");

    public static readonly Status53 MiscCostPending = new("miscCostPending");

    public static readonly Status53 PaymentCost = new("paymentCost");

    public static readonly Status53 PaymentCostPending = new("paymentCostPending");

    public static readonly Status53 Pending = new("pending");

    public static readonly Status53 PendingApproval = new("pendingApproval");

    public static readonly Status53 PendingExecution = new("pendingExecution");

    public static readonly Status53 Received = new("received");

    public static readonly Status53 RefundPending = new("refundPending");

    public static readonly Status53 RefundReversalPending = new("refundReversalPending");

    public static readonly Status53 RefundReversed = new("refundReversed");

    public static readonly Status53 Refunded = new("refunded");

    public static readonly Status53 RefundedExternally = new("refundedExternally");

    public static readonly Status53 Refused = new("refused");

    public static readonly Status53 Rejected = new("rejected");

    public static readonly Status53 ReserveAdjustment = new("reserveAdjustment");

    public static readonly Status53 ReserveAdjustmentPending = new("reserveAdjustmentPending");

    public static readonly Status53 Returned = new("returned");

    public static readonly Status53 Reversed = new("reversed");

    public static readonly Status53 SecondChargeback = new("secondChargeback");

    public static readonly Status53 SecondChargebackPending = new("secondChargebackPending");

    public static readonly Status53 Undefined = new("undefined");

    public static Status53 FromValue(string value) => FromValueCore(value);
}
