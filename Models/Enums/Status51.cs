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
[JsonConverter(typeof(StringEnumConverter<Status51>))]
public sealed record Status51 : StringEnum<Status51>
{
    private Status51(string value) : base(value)
    {
    }

    public static readonly Status51 ApprovalPending = new("approvalPending");

    public static readonly Status51 AtmWithdrawal = new("atmWithdrawal");

    public static readonly Status51 AtmWithdrawalReversalPending = new("atmWithdrawalReversalPending");

    public static readonly Status51 AtmWithdrawalReversed = new("atmWithdrawalReversed");

    public static readonly Status51 AuthAdjustmentAuthorised = new("authAdjustmentAuthorised");

    public static readonly Status51 AuthAdjustmentError = new("authAdjustmentError");

    public static readonly Status51 AuthAdjustmentRefused = new("authAdjustmentRefused");

    public static readonly Status51 Authorised = new("authorised");

    public static readonly Status51 BankTransfer = new("bankTransfer");

    public static readonly Status51 BankTransferPending = new("bankTransferPending");

    public static readonly Status51 Booked = new("booked");

    public static readonly Status51 BookingPending = new("bookingPending");

    public static readonly Status51 Cancelled = new("cancelled");

    public static readonly Status51 CapturePending = new("capturePending");

    public static readonly Status51 CaptureReversalPending = new("captureReversalPending");

    public static readonly Status51 CaptureReversed = new("captureReversed");

    public static readonly Status51 Captured = new("captured");

    public static readonly Status51 CapturedExternally = new("capturedExternally");

    public static readonly Status51 Chargeback = new("chargeback");

    public static readonly Status51 ChargebackExternally = new("chargebackExternally");

    public static readonly Status51 ChargebackPending = new("chargebackPending");

    public static readonly Status51 ChargebackReversalPending = new("chargebackReversalPending");

    public static readonly Status51 ChargebackReversed = new("chargebackReversed");

    public static readonly Status51 Credited = new("credited");

    public static readonly Status51 DepositCorrection = new("depositCorrection");

    public static readonly Status51 DepositCorrectionPending = new("depositCorrectionPending");

    public static readonly Status51 Dispute = new("dispute");

    public static readonly Status51 DisputeClosed = new("disputeClosed");

    public static readonly Status51 DisputeExpired = new("disputeExpired");

    public static readonly Status51 DisputeNeedsReview = new("disputeNeedsReview");

    public static readonly Status51 Error = new("error");

    public static readonly Status51 Expired = new("expired");

    public static readonly Status51 Failed = new("failed");

    public static readonly Status51 Fee = new("fee");

    public static readonly Status51 FeePending = new("feePending");

    public static readonly Status51 InterchangeAdjusted = new("interchangeAdjusted");

    public static readonly Status51 InternalTransfer = new("internalTransfer");

    public static readonly Status51 InternalTransferPending = new("internalTransferPending");

    public static readonly Status51 InvoiceDeduction = new("invoiceDeduction");

    public static readonly Status51 InvoiceDeductionPending = new("invoiceDeductionPending");

    public static readonly Status51 ManualCorrectionPending = new("manualCorrectionPending");

    public static readonly Status51 ManuallyCorrected = new("manuallyCorrected");

    public static readonly Status51 MatchedStatement = new("matchedStatement");

    public static readonly Status51 MatchedStatementPending = new("matchedStatementPending");

    public static readonly Status51 MerchantPayin = new("merchantPayin");

    public static readonly Status51 MerchantPayinPending = new("merchantPayinPending");

    public static readonly Status51 MerchantPayinReversed = new("merchantPayinReversed");

    public static readonly Status51 MerchantPayinReversedPending = new("merchantPayinReversedPending");

    public static readonly Status51 MiscCost = new("miscCost");

    public static readonly Status51 MiscCostPending = new("miscCostPending");

    public static readonly Status51 PaymentCost = new("paymentCost");

    public static readonly Status51 PaymentCostPending = new("paymentCostPending");

    public static readonly Status51 Pending = new("pending");

    public static readonly Status51 PendingApproval = new("pendingApproval");

    public static readonly Status51 PendingExecution = new("pendingExecution");

    public static readonly Status51 Received = new("received");

    public static readonly Status51 RefundPending = new("refundPending");

    public static readonly Status51 RefundReversalPending = new("refundReversalPending");

    public static readonly Status51 RefundReversed = new("refundReversed");

    public static readonly Status51 Refunded = new("refunded");

    public static readonly Status51 RefundedExternally = new("refundedExternally");

    public static readonly Status51 Refused = new("refused");

    public static readonly Status51 Rejected = new("rejected");

    public static readonly Status51 ReserveAdjustment = new("reserveAdjustment");

    public static readonly Status51 ReserveAdjustmentPending = new("reserveAdjustmentPending");

    public static readonly Status51 Returned = new("returned");

    public static readonly Status51 Reversed = new("reversed");

    public static readonly Status51 SecondChargeback = new("secondChargeback");

    public static readonly Status51 SecondChargebackPending = new("secondChargebackPending");

    public static readonly Status51 Undefined = new("undefined");

    public static Status51 FromValue(string value) => FromValueCore(value);
}
