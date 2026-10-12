using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Normal</b>
/// * <b>Refund</b>
/// * <b>OneTimeReservation</b>
/// * <b>FirstReservation</b>
/// * <b>UpdateReservation</b>
/// * <b>Completion</b>
/// * <b>CashAdvance</b>
/// * <b>CashDeposit</b>
/// * <b>Recurring</b>
/// * <b>Instalment</b>
/// * <b>IssuerInstalment</b>
/// * <b>PaidOut</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentType>))]
public sealed record PaymentType : OpenStringEnum<PaymentType>
{
    private PaymentType(string value) : base(value)
    {
    }

    public static readonly PaymentType Normal = new("Normal");

    public static readonly PaymentType Refund = new("Refund");

    public static readonly PaymentType OneTimeReservation = new("OneTimeReservation");

    public static readonly PaymentType FirstReservation = new("FirstReservation");

    public static readonly PaymentType UpdateReservation = new("UpdateReservation");

    public static readonly PaymentType Completion = new("Completion");

    public static readonly PaymentType CashAdvance = new("CashAdvance");

    public static readonly PaymentType CashDeposit = new("CashDeposit");

    public static readonly PaymentType Recurring = new("Recurring");

    public static readonly PaymentType Instalment = new("Instalment");

    public static readonly PaymentType IssuerInstalment = new("IssuerInstalment");

    public static readonly PaymentType PaidOut = new("PaidOut");

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
