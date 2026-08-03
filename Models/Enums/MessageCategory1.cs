using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Category of message.
/// Possible values:
/// * <b>Abort</b>
/// * <b>Admin</b>
/// * <b>BalanceInquiry</b>
/// * <b>Batch</b>
/// * <b>CardAcquisition</b>
/// * <b>CardReaderInit</b>
/// * <b>CardReaderPowerOff</b>
/// * <b>Diagnosis</b>
/// * <b>Display</b>
/// * <b>EnableService</b>
/// * <b>Event</b>
/// * <b>GetTotals</b>
/// * <b>Input</b>
/// * <b>InputUpdate</b>
/// * <b>Login</b>
/// * <b>Logout</b>
/// * <b>Loyalty</b>
/// * <b>None</b>
/// * <b>PIN</b>
/// * <b>Payment</b>
/// * <b>Print</b>
/// * <b>Reconciliation</b>
/// * <b>Reversal</b>
/// * <b>Sound</b>
/// * <b>StoredValue</b>
/// * <b>TransactionStatus</b>
/// * <b>Transmit</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MessageCategory1>))]
public sealed record MessageCategory1 : StringEnum<MessageCategory1>
{
    private MessageCategory1(string value) : base(value)
    {
    }

    public static readonly MessageCategory1 Abort = new("Abort");

    public static readonly MessageCategory1 Admin = new("Admin");

    public static readonly MessageCategory1 BalanceInquiry = new("BalanceInquiry");

    public static readonly MessageCategory1 CardAcquisition = new("CardAcquisition");

    public static readonly MessageCategory1 Diagnosis = new("Diagnosis");

    public static readonly MessageCategory1 Display = new("Display");

    public static readonly MessageCategory1 EnableService = new("EnableService");

    public static readonly MessageCategory1 Event = new("Event");

    public static readonly MessageCategory1 GetTotals = new("GetTotals");

    public static readonly MessageCategory1 Input = new("Input");

    public static readonly MessageCategory1 InputUpdate = new("InputUpdate");

    public static readonly MessageCategory1 Login = new("Login");

    public static readonly MessageCategory1 Logout = new("Logout");

    public static readonly MessageCategory1 Loyalty = new("Loyalty");

    public static readonly MessageCategory1 Payment = new("Payment");

    public static readonly MessageCategory1 Print = new("Print");

    public static readonly MessageCategory1 Reconciliation = new("Reconciliation");

    public static readonly MessageCategory1 Reversal = new("Reversal");

    public static readonly MessageCategory1 StoredValue = new("StoredValue");

    public static readonly MessageCategory1 TransactionStatus = new("TransactionStatus");

    public static readonly MessageCategory1 None = new("None");

    public static MessageCategory1 FromValue(string value) => FromValueCore(value);
}
