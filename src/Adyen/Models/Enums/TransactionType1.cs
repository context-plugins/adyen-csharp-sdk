using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Debit</b>
/// * <b>Credit</b>
/// * <b>ReverseDebit</b>
/// * <b>ReverseCredit</b>
/// * <b>OneTimeReservation</b>
/// * <b>CompletedDeffered</b>
/// * <b>FirstReservation</b>
/// * <b>UpdateReservation</b>
/// * <b>CompletedReservation</b>
/// * <b>CashAdvance</b>
/// * <b>IssuerInstalment</b>
/// * <b>Declined</b>
/// * <b>Failed</b>
/// * <b>Award</b>
/// * <b>ReverseAward</b>
/// * <b>Redemption</b>
/// * <b>ReverseRedemption</b>
/// * <b>Rebate</b>
/// * <b>ReverseRebate</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionType1>))]
public sealed record TransactionType1 : OpenStringEnum<TransactionType1>
{
    private TransactionType1(string value) : base(value)
    {
    }

    public static readonly TransactionType1 Debit = new("Debit");

    public static readonly TransactionType1 Credit = new("Credit");

    public static readonly TransactionType1 ReverseDebit = new("ReverseDebit");

    public static readonly TransactionType1 ReverseCredit = new("ReverseCredit");

    public static readonly TransactionType1 OneTimeReservation = new("OneTimeReservation");

    public static readonly TransactionType1 CompletedDeffered = new("CompletedDeffered");

    public static readonly TransactionType1 FirstReservation = new("FirstReservation");

    public static readonly TransactionType1 UpdateReservation = new("UpdateReservation");

    public static readonly TransactionType1 CompletedReservation = new("CompletedReservation");

    public static readonly TransactionType1 CashAdvance = new("CashAdvance");

    public static readonly TransactionType1 IssuerInstalment = new("IssuerInstalment");

    public static readonly TransactionType1 Declined = new("Declined");

    public static readonly TransactionType1 Failed = new("Failed");

    public static readonly TransactionType1 Award = new("Award");

    public static readonly TransactionType1 ReverseAward = new("ReverseAward");

    public static readonly TransactionType1 Redemption = new("Redemption");

    public static readonly TransactionType1 ReverseRedemption = new("ReverseRedemption");

    public static readonly TransactionType1 Rebate = new("Rebate");

    public static readonly TransactionType1 ReverseRebate = new("ReverseRebate");

    public TResult Match<TResult>(Func<TResult> onDebit,
        Func<TResult> onCredit,
        Func<TResult> onReverseDebit,
        Func<TResult> onReverseCredit,
        Func<TResult> onOneTimeReservation,
        Func<TResult> onCompletedDeffered,
        Func<TResult> onFirstReservation,
        Func<TResult> onUpdateReservation,
        Func<TResult> onCompletedReservation,
        Func<TResult> onCashAdvance,
        Func<TResult> onIssuerInstalment,
        Func<TResult> onDeclined,
        Func<TResult> onFailed,
        Func<TResult> onAward,
        Func<TResult> onReverseAward,
        Func<TResult> onRedemption,
        Func<TResult> onReverseRedemption,
        Func<TResult> onRebate,
        Func<TResult> onReverseRebate,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Debit => onDebit(),
            _ when this == Credit => onCredit(),
            _ when this == ReverseDebit => onReverseDebit(),
            _ when this == ReverseCredit => onReverseCredit(),
            _ when this == OneTimeReservation => onOneTimeReservation(),
            _ when this == CompletedDeffered => onCompletedDeffered(),
            _ when this == FirstReservation => onFirstReservation(),
            _ when this == UpdateReservation => onUpdateReservation(),
            _ when this == CompletedReservation => onCompletedReservation(),
            _ when this == CashAdvance => onCashAdvance(),
            _ when this == IssuerInstalment => onIssuerInstalment(),
            _ when this == Declined => onDeclined(),
            _ when this == Failed => onFailed(),
            _ when this == Award => onAward(),
            _ when this == ReverseAward => onReverseAward(),
            _ when this == Redemption => onRedemption(),
            _ when this == ReverseRedemption => onReverseRedemption(),
            _ when this == Rebate => onRebate(),
            _ when this == ReverseRebate => onReverseRebate(),
            _ => otherwise(Value)
        };

    public void Match(Action onDebit,
        Action onCredit,
        Action onReverseDebit,
        Action onReverseCredit,
        Action onOneTimeReservation,
        Action onCompletedDeffered,
        Action onFirstReservation,
        Action onUpdateReservation,
        Action onCompletedReservation,
        Action onCashAdvance,
        Action onIssuerInstalment,
        Action onDeclined,
        Action onFailed,
        Action onAward,
        Action onReverseAward,
        Action onRedemption,
        Action onReverseRedemption,
        Action onRebate,
        Action onReverseRebate,
        Action<string> otherwise)
    {
        if (this == Debit) onDebit();
        else if (this == Credit) onCredit();
        else if (this == ReverseDebit) onReverseDebit();
        else if (this == ReverseCredit) onReverseCredit();
        else if (this == OneTimeReservation) onOneTimeReservation();
        else if (this == CompletedDeffered) onCompletedDeffered();
        else if (this == FirstReservation) onFirstReservation();
        else if (this == UpdateReservation) onUpdateReservation();
        else if (this == CompletedReservation) onCompletedReservation();
        else if (this == CashAdvance) onCashAdvance();
        else if (this == IssuerInstalment) onIssuerInstalment();
        else if (this == Declined) onDeclined();
        else if (this == Failed) onFailed();
        else if (this == Award) onAward();
        else if (this == ReverseAward) onReverseAward();
        else if (this == Redemption) onRedemption();
        else if (this == ReverseRedemption) onReverseRedemption();
        else if (this == Rebate) onRebate();
        else if (this == ReverseRebate) onReverseRebate();
        else otherwise(Value);
    }
}
