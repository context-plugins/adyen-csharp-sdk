using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transfer event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status24>))]
public sealed record Status24 : OpenStringEnum<Status24>
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

    public TResult Match<TResult>(Func<TResult> onApprovalPending,
        Func<TResult> onAtmWithdrawal,
        Func<TResult> onAtmWithdrawalReversalPending,
        Func<TResult> onAtmWithdrawalReversed,
        Func<TResult> onAuthAdjustmentAuthorised,
        Func<TResult> onAuthAdjustmentError,
        Func<TResult> onAuthAdjustmentRefused,
        Func<TResult> onAuthorised,
        Func<TResult> onBankTransfer,
        Func<TResult> onBankTransferPending,
        Func<TResult> onBooked,
        Func<TResult> onBookingPending,
        Func<TResult> onCancelled,
        Func<TResult> onCapturePending,
        Func<TResult> onCaptureReversalPending,
        Func<TResult> onCaptureReversed,
        Func<TResult> onCaptured,
        Func<TResult> onCapturedExternally,
        Func<TResult> onChargeback,
        Func<TResult> onChargebackExternally,
        Func<TResult> onChargebackPending,
        Func<TResult> onChargebackReversalPending,
        Func<TResult> onChargebackReversed,
        Func<TResult> onCredited,
        Func<TResult> onDepositCorrection,
        Func<TResult> onDepositCorrectionPending,
        Func<TResult> onDispute,
        Func<TResult> onDisputeClosed,
        Func<TResult> onDisputeExpired,
        Func<TResult> onDisputeNeedsReview,
        Func<TResult> onError,
        Func<TResult> onExpired,
        Func<TResult> onFailed,
        Func<TResult> onFee,
        Func<TResult> onFeePending,
        Func<TResult> onInterchangeAdjusted,
        Func<TResult> onInternalTransfer,
        Func<TResult> onInternalTransferPending,
        Func<TResult> onInvoiceDeduction,
        Func<TResult> onInvoiceDeductionPending,
        Func<TResult> onManualCorrectionPending,
        Func<TResult> onManuallyCorrected,
        Func<TResult> onMatchedStatement,
        Func<TResult> onMatchedStatementPending,
        Func<TResult> onMerchantPayin,
        Func<TResult> onMerchantPayinPending,
        Func<TResult> onMerchantPayinReversed,
        Func<TResult> onMerchantPayinReversedPending,
        Func<TResult> onMiscCost,
        Func<TResult> onMiscCostPending,
        Func<TResult> onPaymentCost,
        Func<TResult> onPaymentCostPending,
        Func<TResult> onPending,
        Func<TResult> onPendingApproval,
        Func<TResult> onPendingExecution,
        Func<TResult> onReceived,
        Func<TResult> onRefundPending,
        Func<TResult> onRefundReversalPending,
        Func<TResult> onRefundReversed,
        Func<TResult> onRefunded,
        Func<TResult> onRefundedExternally,
        Func<TResult> onRefused,
        Func<TResult> onRejected,
        Func<TResult> onReserveAdjustment,
        Func<TResult> onReserveAdjustmentPending,
        Func<TResult> onReturned,
        Func<TResult> onReversed,
        Func<TResult> onSecondChargeback,
        Func<TResult> onSecondChargebackPending,
        Func<TResult> onUndefined,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ApprovalPending => onApprovalPending(),
            _ when this == AtmWithdrawal => onAtmWithdrawal(),
            _ when this == AtmWithdrawalReversalPending => onAtmWithdrawalReversalPending(),
            _ when this == AtmWithdrawalReversed => onAtmWithdrawalReversed(),
            _ when this == AuthAdjustmentAuthorised => onAuthAdjustmentAuthorised(),
            _ when this == AuthAdjustmentError => onAuthAdjustmentError(),
            _ when this == AuthAdjustmentRefused => onAuthAdjustmentRefused(),
            _ when this == Authorised => onAuthorised(),
            _ when this == BankTransfer => onBankTransfer(),
            _ when this == BankTransferPending => onBankTransferPending(),
            _ when this == Booked => onBooked(),
            _ when this == BookingPending => onBookingPending(),
            _ when this == Cancelled => onCancelled(),
            _ when this == CapturePending => onCapturePending(),
            _ when this == CaptureReversalPending => onCaptureReversalPending(),
            _ when this == CaptureReversed => onCaptureReversed(),
            _ when this == Captured => onCaptured(),
            _ when this == CapturedExternally => onCapturedExternally(),
            _ when this == Chargeback => onChargeback(),
            _ when this == ChargebackExternally => onChargebackExternally(),
            _ when this == ChargebackPending => onChargebackPending(),
            _ when this == ChargebackReversalPending => onChargebackReversalPending(),
            _ when this == ChargebackReversed => onChargebackReversed(),
            _ when this == Credited => onCredited(),
            _ when this == DepositCorrection => onDepositCorrection(),
            _ when this == DepositCorrectionPending => onDepositCorrectionPending(),
            _ when this == Dispute => onDispute(),
            _ when this == DisputeClosed => onDisputeClosed(),
            _ when this == DisputeExpired => onDisputeExpired(),
            _ when this == DisputeNeedsReview => onDisputeNeedsReview(),
            _ when this == Error => onError(),
            _ when this == Expired => onExpired(),
            _ when this == Failed => onFailed(),
            _ when this == Fee => onFee(),
            _ when this == FeePending => onFeePending(),
            _ when this == InterchangeAdjusted => onInterchangeAdjusted(),
            _ when this == InternalTransfer => onInternalTransfer(),
            _ when this == InternalTransferPending => onInternalTransferPending(),
            _ when this == InvoiceDeduction => onInvoiceDeduction(),
            _ when this == InvoiceDeductionPending => onInvoiceDeductionPending(),
            _ when this == ManualCorrectionPending => onManualCorrectionPending(),
            _ when this == ManuallyCorrected => onManuallyCorrected(),
            _ when this == MatchedStatement => onMatchedStatement(),
            _ when this == MatchedStatementPending => onMatchedStatementPending(),
            _ when this == MerchantPayin => onMerchantPayin(),
            _ when this == MerchantPayinPending => onMerchantPayinPending(),
            _ when this == MerchantPayinReversed => onMerchantPayinReversed(),
            _ when this == MerchantPayinReversedPending => onMerchantPayinReversedPending(),
            _ when this == MiscCost => onMiscCost(),
            _ when this == MiscCostPending => onMiscCostPending(),
            _ when this == PaymentCost => onPaymentCost(),
            _ when this == PaymentCostPending => onPaymentCostPending(),
            _ when this == Pending => onPending(),
            _ when this == PendingApproval => onPendingApproval(),
            _ when this == PendingExecution => onPendingExecution(),
            _ when this == Received => onReceived(),
            _ when this == RefundPending => onRefundPending(),
            _ when this == RefundReversalPending => onRefundReversalPending(),
            _ when this == RefundReversed => onRefundReversed(),
            _ when this == Refunded => onRefunded(),
            _ when this == RefundedExternally => onRefundedExternally(),
            _ when this == Refused => onRefused(),
            _ when this == Rejected => onRejected(),
            _ when this == ReserveAdjustment => onReserveAdjustment(),
            _ when this == ReserveAdjustmentPending => onReserveAdjustmentPending(),
            _ when this == Returned => onReturned(),
            _ when this == Reversed => onReversed(),
            _ when this == SecondChargeback => onSecondChargeback(),
            _ when this == SecondChargebackPending => onSecondChargebackPending(),
            _ when this == Undefined => onUndefined(),
            _ => otherwise(Value)
        };

    public void Match(Action onApprovalPending,
        Action onAtmWithdrawal,
        Action onAtmWithdrawalReversalPending,
        Action onAtmWithdrawalReversed,
        Action onAuthAdjustmentAuthorised,
        Action onAuthAdjustmentError,
        Action onAuthAdjustmentRefused,
        Action onAuthorised,
        Action onBankTransfer,
        Action onBankTransferPending,
        Action onBooked,
        Action onBookingPending,
        Action onCancelled,
        Action onCapturePending,
        Action onCaptureReversalPending,
        Action onCaptureReversed,
        Action onCaptured,
        Action onCapturedExternally,
        Action onChargeback,
        Action onChargebackExternally,
        Action onChargebackPending,
        Action onChargebackReversalPending,
        Action onChargebackReversed,
        Action onCredited,
        Action onDepositCorrection,
        Action onDepositCorrectionPending,
        Action onDispute,
        Action onDisputeClosed,
        Action onDisputeExpired,
        Action onDisputeNeedsReview,
        Action onError,
        Action onExpired,
        Action onFailed,
        Action onFee,
        Action onFeePending,
        Action onInterchangeAdjusted,
        Action onInternalTransfer,
        Action onInternalTransferPending,
        Action onInvoiceDeduction,
        Action onInvoiceDeductionPending,
        Action onManualCorrectionPending,
        Action onManuallyCorrected,
        Action onMatchedStatement,
        Action onMatchedStatementPending,
        Action onMerchantPayin,
        Action onMerchantPayinPending,
        Action onMerchantPayinReversed,
        Action onMerchantPayinReversedPending,
        Action onMiscCost,
        Action onMiscCostPending,
        Action onPaymentCost,
        Action onPaymentCostPending,
        Action onPending,
        Action onPendingApproval,
        Action onPendingExecution,
        Action onReceived,
        Action onRefundPending,
        Action onRefundReversalPending,
        Action onRefundReversed,
        Action onRefunded,
        Action onRefundedExternally,
        Action onRefused,
        Action onRejected,
        Action onReserveAdjustment,
        Action onReserveAdjustmentPending,
        Action onReturned,
        Action onReversed,
        Action onSecondChargeback,
        Action onSecondChargebackPending,
        Action onUndefined,
        Action<string> otherwise)
    {
        if (this == ApprovalPending) onApprovalPending();
        else if (this == AtmWithdrawal) onAtmWithdrawal();
        else if (this == AtmWithdrawalReversalPending) onAtmWithdrawalReversalPending();
        else if (this == AtmWithdrawalReversed) onAtmWithdrawalReversed();
        else if (this == AuthAdjustmentAuthorised) onAuthAdjustmentAuthorised();
        else if (this == AuthAdjustmentError) onAuthAdjustmentError();
        else if (this == AuthAdjustmentRefused) onAuthAdjustmentRefused();
        else if (this == Authorised) onAuthorised();
        else if (this == BankTransfer) onBankTransfer();
        else if (this == BankTransferPending) onBankTransferPending();
        else if (this == Booked) onBooked();
        else if (this == BookingPending) onBookingPending();
        else if (this == Cancelled) onCancelled();
        else if (this == CapturePending) onCapturePending();
        else if (this == CaptureReversalPending) onCaptureReversalPending();
        else if (this == CaptureReversed) onCaptureReversed();
        else if (this == Captured) onCaptured();
        else if (this == CapturedExternally) onCapturedExternally();
        else if (this == Chargeback) onChargeback();
        else if (this == ChargebackExternally) onChargebackExternally();
        else if (this == ChargebackPending) onChargebackPending();
        else if (this == ChargebackReversalPending) onChargebackReversalPending();
        else if (this == ChargebackReversed) onChargebackReversed();
        else if (this == Credited) onCredited();
        else if (this == DepositCorrection) onDepositCorrection();
        else if (this == DepositCorrectionPending) onDepositCorrectionPending();
        else if (this == Dispute) onDispute();
        else if (this == DisputeClosed) onDisputeClosed();
        else if (this == DisputeExpired) onDisputeExpired();
        else if (this == DisputeNeedsReview) onDisputeNeedsReview();
        else if (this == Error) onError();
        else if (this == Expired) onExpired();
        else if (this == Failed) onFailed();
        else if (this == Fee) onFee();
        else if (this == FeePending) onFeePending();
        else if (this == InterchangeAdjusted) onInterchangeAdjusted();
        else if (this == InternalTransfer) onInternalTransfer();
        else if (this == InternalTransferPending) onInternalTransferPending();
        else if (this == InvoiceDeduction) onInvoiceDeduction();
        else if (this == InvoiceDeductionPending) onInvoiceDeductionPending();
        else if (this == ManualCorrectionPending) onManualCorrectionPending();
        else if (this == ManuallyCorrected) onManuallyCorrected();
        else if (this == MatchedStatement) onMatchedStatement();
        else if (this == MatchedStatementPending) onMatchedStatementPending();
        else if (this == MerchantPayin) onMerchantPayin();
        else if (this == MerchantPayinPending) onMerchantPayinPending();
        else if (this == MerchantPayinReversed) onMerchantPayinReversed();
        else if (this == MerchantPayinReversedPending) onMerchantPayinReversedPending();
        else if (this == MiscCost) onMiscCost();
        else if (this == MiscCostPending) onMiscCostPending();
        else if (this == PaymentCost) onPaymentCost();
        else if (this == PaymentCostPending) onPaymentCostPending();
        else if (this == Pending) onPending();
        else if (this == PendingApproval) onPendingApproval();
        else if (this == PendingExecution) onPendingExecution();
        else if (this == Received) onReceived();
        else if (this == RefundPending) onRefundPending();
        else if (this == RefundReversalPending) onRefundReversalPending();
        else if (this == RefundReversed) onRefundReversed();
        else if (this == Refunded) onRefunded();
        else if (this == RefundedExternally) onRefundedExternally();
        else if (this == Refused) onRefused();
        else if (this == Rejected) onRejected();
        else if (this == ReserveAdjustment) onReserveAdjustment();
        else if (this == ReserveAdjustmentPending) onReserveAdjustmentPending();
        else if (this == Returned) onReturned();
        else if (this == Reversed) onReversed();
        else if (this == SecondChargeback) onSecondChargeback();
        else if (this == SecondChargebackPending) onSecondChargebackPending();
        else if (this == Undefined) onUndefined();
        else otherwise(Value);
    }
}
