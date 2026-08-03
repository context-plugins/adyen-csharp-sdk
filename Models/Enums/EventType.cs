using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of event.
/// <para>
/// Possible values: <b>ACCOUNT_CLOSED</b>, <b>ACCOUNT_CREATED</b>, <b>ACCOUNT_FUNDS_BELOW_THRESHOLD</b>, <b>ACCOUNT_HOLDER_CREATED</b>, <b>ACCOUNT_HOLDER_LIMIT_REACHED</b>, <b>ACCOUNT_HOLDER_PAYOUT</b>, <b>ACCOUNT_HOLDER_STATUS_CHANGE</b>, <b>ACCOUNT_HOLDER_STORE_STATUS_CHANGE</b>, <b>ACCOUNT_HOLDER_UPCOMING_DEADLINE</b>, <b>ACCOUNT_HOLDER_UPDATED</b>, <b>ACCOUNT_HOLDER_VERIFICATION</b>, <b>ACCOUNT_UPDATED</b>, <b>BENEFICIARY_SETUP</b>, <b>COMPENSATE_NEGATIVE_BALANCE</b>, <b>DIRECT_DEBIT_INITIATED</b>, <b>PAYMENT_FAILURE</b>, <b>REFUND_FUNDS_TRANSFER</b>, <b>REPORT_AVAILABLE</b>, <b>SCHEDULED_REFUNDS</b>, <b>TRANSFER_FUNDS</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EventType>))]
public sealed record EventType : StringEnum<EventType>
{
    private EventType(string value) : base(value)
    {
    }

    public static readonly EventType AccountClosed = new("ACCOUNT_CLOSED");

    public static readonly EventType AccountCreated = new("ACCOUNT_CREATED");

    public static readonly EventType AccountFundsBelowThreshold = new("ACCOUNT_FUNDS_BELOW_THRESHOLD");

    public static readonly EventType AccountHolderCreated = new("ACCOUNT_HOLDER_CREATED");

    public static readonly EventType AccountHolderLimitReached = new("ACCOUNT_HOLDER_LIMIT_REACHED");

    public static readonly EventType AccountHolderMigrated = new("ACCOUNT_HOLDER_MIGRATED");

    public static readonly EventType AccountHolderPayout = new("ACCOUNT_HOLDER_PAYOUT");

    public static readonly EventType AccountHolderStatusChange = new("ACCOUNT_HOLDER_STATUS_CHANGE");

    public static readonly EventType AccountHolderStoreStatusChange = new("ACCOUNT_HOLDER_STORE_STATUS_CHANGE");

    public static readonly EventType AccountHolderUpcomingDeadline = new("ACCOUNT_HOLDER_UPCOMING_DEADLINE");

    public static readonly EventType AccountHolderUpdated = new("ACCOUNT_HOLDER_UPDATED");

    public static readonly EventType AccountHolderVerification = new("ACCOUNT_HOLDER_VERIFICATION");

    public static readonly EventType AccountUpdated = new("ACCOUNT_UPDATED");

    public static readonly EventType BeneficiarySetup = new("BENEFICIARY_SETUP");

    public static readonly EventType CompensateNegativeBalance = new("COMPENSATE_NEGATIVE_BALANCE");

    public static readonly EventType DirectDebitInitiated = new("DIRECT_DEBIT_INITIATED");

    public static readonly EventType FundsMigrated = new("FUNDS_MIGRATED");

    public static readonly EventType PaymentFailure = new("PAYMENT_FAILURE");

    public static readonly EventType PendingCredit = new("PENDING_CREDIT");

    public static readonly EventType RefundFundsTransfer = new("REFUND_FUNDS_TRANSFER");

    public static readonly EventType ReportAvailable = new("REPORT_AVAILABLE");

    public static readonly EventType ScheduledRefunds = new("SCHEDULED_REFUNDS");

    public static readonly EventType ScoreSignalTriggered = new("SCORE_SIGNAL_TRIGGERED");

    public static readonly EventType TransferFunds = new("TRANSFER_FUNDS");

    public static readonly EventType TransferNotPaidoutTransfers = new("TRANSFER_NOT_PAIDOUT_TRANSFERS");

    public static EventType FromValue(string value) => FromValueCore(value);
}
