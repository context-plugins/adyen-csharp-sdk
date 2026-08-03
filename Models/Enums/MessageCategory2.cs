using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Category of message.
/// CardAcquisition, Display, Input, Loyalty, Payment, Print, CardReaderInit, CardReaderPowerOff.
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
[JsonConverter(typeof(StringEnumConverter<MessageCategory2>))]
public sealed record MessageCategory2 : StringEnum<MessageCategory2>
{
    private MessageCategory2(string value) : base(value)
    {
    }

    public static readonly MessageCategory2 Abort = new("Abort");

    public static readonly MessageCategory2 Admin = new("Admin");

    public static readonly MessageCategory2 BalanceInquiry = new("BalanceInquiry");

    public static readonly MessageCategory2 CardAcquisition = new("CardAcquisition");

    public static readonly MessageCategory2 Diagnosis = new("Diagnosis");

    public static readonly MessageCategory2 Display = new("Display");

    public static readonly MessageCategory2 EnableService = new("EnableService");

    public static readonly MessageCategory2 Event = new("Event");

    public static readonly MessageCategory2 GetTotals = new("GetTotals");

    public static readonly MessageCategory2 Input = new("Input");

    public static readonly MessageCategory2 InputUpdate = new("InputUpdate");

    public static readonly MessageCategory2 Login = new("Login");

    public static readonly MessageCategory2 Logout = new("Logout");

    public static readonly MessageCategory2 Loyalty = new("Loyalty");

    public static readonly MessageCategory2 Payment = new("Payment");

    public static readonly MessageCategory2 Print = new("Print");

    public static readonly MessageCategory2 Reconciliation = new("Reconciliation");

    public static readonly MessageCategory2 Reversal = new("Reversal");

    public static readonly MessageCategory2 StoredValue = new("StoredValue");

    public static readonly MessageCategory2 TransactionStatus = new("TransactionStatus");

    public static readonly MessageCategory2 None = new("None");

    public static MessageCategory2 FromValue(string value) => FromValueCore(value);
}
