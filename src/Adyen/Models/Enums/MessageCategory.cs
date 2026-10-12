using System;
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
public sealed record MessageCategory : OpenStringEnum<MessageCategory>
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

    public TResult Match<TResult>(Func<TResult> onAbort,
        Func<TResult> onAdmin,
        Func<TResult> onBalanceInquiry,
        Func<TResult> onCardAcquisition,
        Func<TResult> onDiagnosis,
        Func<TResult> onDisplay,
        Func<TResult> onEnableService,
        Func<TResult> onEvent,
        Func<TResult> onGetTotals,
        Func<TResult> onInput,
        Func<TResult> onInputUpdate,
        Func<TResult> onLogin,
        Func<TResult> onLogout,
        Func<TResult> onLoyalty,
        Func<TResult> onPayment,
        Func<TResult> onPrint,
        Func<TResult> onReconciliation,
        Func<TResult> onReversal,
        Func<TResult> onStoredValue,
        Func<TResult> onTransactionStatus,
        Func<TResult> onNone,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Abort => onAbort(),
            _ when this == Admin => onAdmin(),
            _ when this == BalanceInquiry => onBalanceInquiry(),
            _ when this == CardAcquisition => onCardAcquisition(),
            _ when this == Diagnosis => onDiagnosis(),
            _ when this == Display => onDisplay(),
            _ when this == EnableService => onEnableService(),
            _ when this == Event => onEvent(),
            _ when this == GetTotals => onGetTotals(),
            _ when this == Input => onInput(),
            _ when this == InputUpdate => onInputUpdate(),
            _ when this == Login => onLogin(),
            _ when this == Logout => onLogout(),
            _ when this == Loyalty => onLoyalty(),
            _ when this == Payment => onPayment(),
            _ when this == Print => onPrint(),
            _ when this == Reconciliation => onReconciliation(),
            _ when this == Reversal => onReversal(),
            _ when this == StoredValue => onStoredValue(),
            _ when this == TransactionStatus => onTransactionStatus(),
            _ when this == None => onNone(),
            _ => otherwise(Value)
        };

    public void Match(Action onAbort,
        Action onAdmin,
        Action onBalanceInquiry,
        Action onCardAcquisition,
        Action onDiagnosis,
        Action onDisplay,
        Action onEnableService,
        Action onEvent,
        Action onGetTotals,
        Action onInput,
        Action onInputUpdate,
        Action onLogin,
        Action onLogout,
        Action onLoyalty,
        Action onPayment,
        Action onPrint,
        Action onReconciliation,
        Action onReversal,
        Action onStoredValue,
        Action onTransactionStatus,
        Action onNone,
        Action<string> otherwise)
    {
        if (this == Abort) onAbort();
        else if (this == Admin) onAdmin();
        else if (this == BalanceInquiry) onBalanceInquiry();
        else if (this == CardAcquisition) onCardAcquisition();
        else if (this == Diagnosis) onDiagnosis();
        else if (this == Display) onDisplay();
        else if (this == EnableService) onEnableService();
        else if (this == Event) onEvent();
        else if (this == GetTotals) onGetTotals();
        else if (this == Input) onInput();
        else if (this == InputUpdate) onInputUpdate();
        else if (this == Login) onLogin();
        else if (this == Logout) onLogout();
        else if (this == Loyalty) onLoyalty();
        else if (this == Payment) onPayment();
        else if (this == Print) onPrint();
        else if (this == Reconciliation) onReconciliation();
        else if (this == Reversal) onReversal();
        else if (this == StoredValue) onStoredValue();
        else if (this == TransactionStatus) onTransactionStatus();
        else if (this == None) onNone();
        else otherwise(Value);
    }
}
