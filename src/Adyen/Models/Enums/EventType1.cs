using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EventType1>))]
public sealed record EventType1 : OpenStringEnum<EventType1>
{
    private EventType1(string value) : base(value)
    {
    }

    public static readonly EventType1 AccountClosed = new("ACCOUNT_CLOSED");

    public static readonly EventType1 AccountCreated = new("ACCOUNT_CREATED");

    public static readonly EventType1 AccountFundsBelowThreshold = new("ACCOUNT_FUNDS_BELOW_THRESHOLD");

    public static readonly EventType1 AccountHolderCreated = new("ACCOUNT_HOLDER_CREATED");

    public static readonly EventType1 AccountHolderLimitReached = new("ACCOUNT_HOLDER_LIMIT_REACHED");

    public static readonly EventType1 AccountHolderMigrated = new("ACCOUNT_HOLDER_MIGRATED");

    public static readonly EventType1 AccountHolderPayout = new("ACCOUNT_HOLDER_PAYOUT");

    public static readonly EventType1 AccountHolderStatusChange = new("ACCOUNT_HOLDER_STATUS_CHANGE");

    public static readonly EventType1 AccountHolderStoreStatusChange = new("ACCOUNT_HOLDER_STORE_STATUS_CHANGE");

    public static readonly EventType1 AccountHolderUpcomingDeadline = new("ACCOUNT_HOLDER_UPCOMING_DEADLINE");

    public static readonly EventType1 AccountHolderUpdated = new("ACCOUNT_HOLDER_UPDATED");

    public static readonly EventType1 AccountHolderVerification = new("ACCOUNT_HOLDER_VERIFICATION");

    public static readonly EventType1 AccountUpdated = new("ACCOUNT_UPDATED");

    public static readonly EventType1 BeneficiarySetup = new("BENEFICIARY_SETUP");

    public static readonly EventType1 CompensateNegativeBalance = new("COMPENSATE_NEGATIVE_BALANCE");

    public static readonly EventType1 DirectDebitInitiated = new("DIRECT_DEBIT_INITIATED");

    public static readonly EventType1 FundsMigrated = new("FUNDS_MIGRATED");

    public static readonly EventType1 PaymentFailure = new("PAYMENT_FAILURE");

    public static readonly EventType1 PendingCredit = new("PENDING_CREDIT");

    public static readonly EventType1 RefundFundsTransfer = new("REFUND_FUNDS_TRANSFER");

    public static readonly EventType1 ReportAvailable = new("REPORT_AVAILABLE");

    public static readonly EventType1 ScheduledRefunds = new("SCHEDULED_REFUNDS");

    public static readonly EventType1 ScoreSignalTriggered = new("SCORE_SIGNAL_TRIGGERED");

    public static readonly EventType1 TransferFunds = new("TRANSFER_FUNDS");

    public static readonly EventType1 TransferNotPaidoutTransfers = new("TRANSFER_NOT_PAIDOUT_TRANSFERS");

    public TResult Match<TResult>(Func<TResult> onAccountClosed,
        Func<TResult> onAccountCreated,
        Func<TResult> onAccountFundsBelowThreshold,
        Func<TResult> onAccountHolderCreated,
        Func<TResult> onAccountHolderLimitReached,
        Func<TResult> onAccountHolderMigrated,
        Func<TResult> onAccountHolderPayout,
        Func<TResult> onAccountHolderStatusChange,
        Func<TResult> onAccountHolderStoreStatusChange,
        Func<TResult> onAccountHolderUpcomingDeadline,
        Func<TResult> onAccountHolderUpdated,
        Func<TResult> onAccountHolderVerification,
        Func<TResult> onAccountUpdated,
        Func<TResult> onBeneficiarySetup,
        Func<TResult> onCompensateNegativeBalance,
        Func<TResult> onDirectDebitInitiated,
        Func<TResult> onFundsMigrated,
        Func<TResult> onPaymentFailure,
        Func<TResult> onPendingCredit,
        Func<TResult> onRefundFundsTransfer,
        Func<TResult> onReportAvailable,
        Func<TResult> onScheduledRefunds,
        Func<TResult> onScoreSignalTriggered,
        Func<TResult> onTransferFunds,
        Func<TResult> onTransferNotPaidoutTransfers,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountClosed => onAccountClosed(),
            _ when this == AccountCreated => onAccountCreated(),
            _ when this == AccountFundsBelowThreshold => onAccountFundsBelowThreshold(),
            _ when this == AccountHolderCreated => onAccountHolderCreated(),
            _ when this == AccountHolderLimitReached => onAccountHolderLimitReached(),
            _ when this == AccountHolderMigrated => onAccountHolderMigrated(),
            _ when this == AccountHolderPayout => onAccountHolderPayout(),
            _ when this == AccountHolderStatusChange => onAccountHolderStatusChange(),
            _ when this == AccountHolderStoreStatusChange => onAccountHolderStoreStatusChange(),
            _ when this == AccountHolderUpcomingDeadline => onAccountHolderUpcomingDeadline(),
            _ when this == AccountHolderUpdated => onAccountHolderUpdated(),
            _ when this == AccountHolderVerification => onAccountHolderVerification(),
            _ when this == AccountUpdated => onAccountUpdated(),
            _ when this == BeneficiarySetup => onBeneficiarySetup(),
            _ when this == CompensateNegativeBalance => onCompensateNegativeBalance(),
            _ when this == DirectDebitInitiated => onDirectDebitInitiated(),
            _ when this == FundsMigrated => onFundsMigrated(),
            _ when this == PaymentFailure => onPaymentFailure(),
            _ when this == PendingCredit => onPendingCredit(),
            _ when this == RefundFundsTransfer => onRefundFundsTransfer(),
            _ when this == ReportAvailable => onReportAvailable(),
            _ when this == ScheduledRefunds => onScheduledRefunds(),
            _ when this == ScoreSignalTriggered => onScoreSignalTriggered(),
            _ when this == TransferFunds => onTransferFunds(),
            _ when this == TransferNotPaidoutTransfers => onTransferNotPaidoutTransfers(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountClosed,
        Action onAccountCreated,
        Action onAccountFundsBelowThreshold,
        Action onAccountHolderCreated,
        Action onAccountHolderLimitReached,
        Action onAccountHolderMigrated,
        Action onAccountHolderPayout,
        Action onAccountHolderStatusChange,
        Action onAccountHolderStoreStatusChange,
        Action onAccountHolderUpcomingDeadline,
        Action onAccountHolderUpdated,
        Action onAccountHolderVerification,
        Action onAccountUpdated,
        Action onBeneficiarySetup,
        Action onCompensateNegativeBalance,
        Action onDirectDebitInitiated,
        Action onFundsMigrated,
        Action onPaymentFailure,
        Action onPendingCredit,
        Action onRefundFundsTransfer,
        Action onReportAvailable,
        Action onScheduledRefunds,
        Action onScoreSignalTriggered,
        Action onTransferFunds,
        Action onTransferNotPaidoutTransfers,
        Action<string> otherwise)
    {
        if (this == AccountClosed) onAccountClosed();
        else if (this == AccountCreated) onAccountCreated();
        else if (this == AccountFundsBelowThreshold) onAccountFundsBelowThreshold();
        else if (this == AccountHolderCreated) onAccountHolderCreated();
        else if (this == AccountHolderLimitReached) onAccountHolderLimitReached();
        else if (this == AccountHolderMigrated) onAccountHolderMigrated();
        else if (this == AccountHolderPayout) onAccountHolderPayout();
        else if (this == AccountHolderStatusChange) onAccountHolderStatusChange();
        else if (this == AccountHolderStoreStatusChange) onAccountHolderStoreStatusChange();
        else if (this == AccountHolderUpcomingDeadline) onAccountHolderUpcomingDeadline();
        else if (this == AccountHolderUpdated) onAccountHolderUpdated();
        else if (this == AccountHolderVerification) onAccountHolderVerification();
        else if (this == AccountUpdated) onAccountUpdated();
        else if (this == BeneficiarySetup) onBeneficiarySetup();
        else if (this == CompensateNegativeBalance) onCompensateNegativeBalance();
        else if (this == DirectDebitInitiated) onDirectDebitInitiated();
        else if (this == FundsMigrated) onFundsMigrated();
        else if (this == PaymentFailure) onPaymentFailure();
        else if (this == PendingCredit) onPendingCredit();
        else if (this == RefundFundsTransfer) onRefundFundsTransfer();
        else if (this == ReportAvailable) onReportAvailable();
        else if (this == ScheduledRefunds) onScheduledRefunds();
        else if (this == ScoreSignalTriggered) onScoreSignalTriggered();
        else if (this == TransferFunds) onTransferFunds();
        else if (this == TransferNotPaidoutTransfers) onTransferNotPaidoutTransfers();
        else otherwise(Value);
    }
}
