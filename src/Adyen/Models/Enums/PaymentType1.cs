using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of payment transaction. Elements requested by the Sale System that are related to the payment only.
/// Possible values:
/// * <b>CashAdvance</b>
/// * <b>CashDeposit</b>
/// * <b>Completion</b>
/// * <b>FirstReservation</b>
/// * <b>Instalment</b>
/// * <b>IssuerInstalment</b>
/// * <b>Normal</b>
/// * <b>OneTimeReservation</b>
/// * <b>PaidOut</b>
/// * <b>Recurring</b>
/// * <b>Refund</b>
/// * <b>UpdateReservation</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentType1>))]
public sealed record PaymentType1 : OpenStringEnum<PaymentType1>
{
    private PaymentType1(string value) : base(value)
    {
    }

    public static readonly PaymentType1 Normal = new("Normal");

    public static readonly PaymentType1 Refund = new("Refund");

    public static readonly PaymentType1 OneTimeReservation = new("OneTimeReservation");

    public static readonly PaymentType1 FirstReservation = new("FirstReservation");

    public static readonly PaymentType1 UpdateReservation = new("UpdateReservation");

    public static readonly PaymentType1 Completion = new("Completion");

    public static readonly PaymentType1 CashAdvance = new("CashAdvance");

    public static readonly PaymentType1 CashDeposit = new("CashDeposit");

    public static readonly PaymentType1 Recurring = new("Recurring");

    public static readonly PaymentType1 Instalment = new("Instalment");

    public static readonly PaymentType1 IssuerInstalment = new("IssuerInstalment");

    public static readonly PaymentType1 PaidOut = new("PaidOut");

    public TResult Match<TResult>(Func<TResult> onNormal,
        Func<TResult> onRefund,
        Func<TResult> onOneTimeReservation,
        Func<TResult> onFirstReservation,
        Func<TResult> onUpdateReservation,
        Func<TResult> onCompletion,
        Func<TResult> onCashAdvance,
        Func<TResult> onCashDeposit,
        Func<TResult> onRecurring,
        Func<TResult> onInstalment,
        Func<TResult> onIssuerInstalment,
        Func<TResult> onPaidOut,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Normal => onNormal(),
            _ when this == Refund => onRefund(),
            _ when this == OneTimeReservation => onOneTimeReservation(),
            _ when this == FirstReservation => onFirstReservation(),
            _ when this == UpdateReservation => onUpdateReservation(),
            _ when this == Completion => onCompletion(),
            _ when this == CashAdvance => onCashAdvance(),
            _ when this == CashDeposit => onCashDeposit(),
            _ when this == Recurring => onRecurring(),
            _ when this == Instalment => onInstalment(),
            _ when this == IssuerInstalment => onIssuerInstalment(),
            _ when this == PaidOut => onPaidOut(),
            _ => otherwise(Value)
        };

    public void Match(Action onNormal,
        Action onRefund,
        Action onOneTimeReservation,
        Action onFirstReservation,
        Action onUpdateReservation,
        Action onCompletion,
        Action onCashAdvance,
        Action onCashDeposit,
        Action onRecurring,
        Action onInstalment,
        Action onIssuerInstalment,
        Action onPaidOut,
        Action<string> otherwise)
    {
        if (this == Normal) onNormal();
        else if (this == Refund) onRefund();
        else if (this == OneTimeReservation) onOneTimeReservation();
        else if (this == FirstReservation) onFirstReservation();
        else if (this == UpdateReservation) onUpdateReservation();
        else if (this == Completion) onCompletion();
        else if (this == CashAdvance) onCashAdvance();
        else if (this == CashDeposit) onCashDeposit();
        else if (this == Recurring) onRecurring();
        else if (this == Instalment) onInstalment();
        else if (this == IssuerInstalment) onIssuerInstalment();
        else if (this == PaidOut) onPaidOut();
        else otherwise(Value);
    }
}
