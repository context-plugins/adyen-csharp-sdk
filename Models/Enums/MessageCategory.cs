using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Abort</b>
/// * <b>Admin</b>
/// * <b>BalanceInquiry</b>
/// * <b>CardAcquisition</b>
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
/// * <b>Payment</b>
/// * <b>Print</b>
/// * <b>Reconciliation</b>
/// * <b>Reversal</b>
/// * <b>StoredValue</b>
/// * <b>TransactionStatus</b>
/// * <b>None</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MessageCategory>))]
public sealed record MessageCategory : StringEnum<MessageCategory>
{
    private MessageCategory(string value) : base(value)
    {
    }

    public static readonly MessageCategory Abort = new("Abort");

    public static readonly MessageCategory Admin = new("Admin");

    public static readonly MessageCategory BalanceInquiry = new("BalanceInquiry");

    public static readonly MessageCategory CardAcquisition = new("CardAcquisition");

    public static readonly MessageCategory Diagnosis = new("Diagnosis");

    public static readonly MessageCategory Display = new("Display");

    public static readonly MessageCategory EnableService = new("EnableService");

    public static readonly MessageCategory Event = new("Event");

    public static readonly MessageCategory GetTotals = new("GetTotals");

    public static readonly MessageCategory Input = new("Input");

    public static readonly MessageCategory InputUpdate = new("InputUpdate");

    public static readonly MessageCategory Login = new("Login");

    public static readonly MessageCategory Logout = new("Logout");

    public static readonly MessageCategory Loyalty = new("Loyalty");

    public static readonly MessageCategory Payment = new("Payment");

    public static readonly MessageCategory Print = new("Print");

    public static readonly MessageCategory Reconciliation = new("Reconciliation");

    public static readonly MessageCategory Reversal = new("Reversal");

    public static readonly MessageCategory StoredValue = new("StoredValue");

    public static readonly MessageCategory TransactionStatus = new("TransactionStatus");

    public static readonly MessageCategory None = new("None");

    public static MessageCategory FromValue(string value) => FromValueCore(value);
}
