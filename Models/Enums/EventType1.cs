using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EventType1>))]
public sealed record EventType1 : StringEnum<EventType1>
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

    public static EventType1 FromValue(string value) => FromValueCore(value);
}
