using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of transaction for which totals are grouped.
/// Debit, Credit, ReverseDebit, ReverseCredit, OneTimeReservation, CompletedDeffered, FirstReservation, UpdateReservation, CompletedReservation, CashAdvance.
/// Possible values:
/// * <b>Award</b>
/// * <b>CashAdvance</b>
/// * <b>CompletedDeffered</b>
/// * <b>CompletedReservation</b>
/// * <b>Credit</b>
/// * <b>Debit</b>
/// * <b>Declined</b>
/// * <b>Failed</b>
/// * <b>FirstReservation</b>
/// * <b>IssuerInstalment</b>
/// * <b>OneTimeReservation</b>
/// * <b>Rebate</b>
/// * <b>Redemption</b>
/// * <b>ReverseAward</b>
/// * <b>ReverseCredit</b>
/// * <b>ReverseDebit</b>
/// * <b>ReverseRebate</b>
/// * <b>ReverseRedemption</b>
/// * <b>UpdateReservation</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionType11>))]
public sealed record TransactionType11 : StringEnum<TransactionType11>
{
    private TransactionType11(string value) : base(value)
    {
    }

    public static readonly TransactionType11 Debit = new("Debit");

    public static readonly TransactionType11 Credit = new("Credit");

    public static readonly TransactionType11 ReverseDebit = new("ReverseDebit");

    public static readonly TransactionType11 ReverseCredit = new("ReverseCredit");

    public static readonly TransactionType11 OneTimeReservation = new("OneTimeReservation");

    public static readonly TransactionType11 CompletedDeffered = new("CompletedDeffered");

    public static readonly TransactionType11 FirstReservation = new("FirstReservation");

    public static readonly TransactionType11 UpdateReservation = new("UpdateReservation");

    public static readonly TransactionType11 CompletedReservation = new("CompletedReservation");

    public static readonly TransactionType11 CashAdvance = new("CashAdvance");

    public static readonly TransactionType11 IssuerInstalment = new("IssuerInstalment");

    public static readonly TransactionType11 Declined = new("Declined");

    public static readonly TransactionType11 Failed = new("Failed");

    public static readonly TransactionType11 Award = new("Award");

    public static readonly TransactionType11 ReverseAward = new("ReverseAward");

    public static readonly TransactionType11 Redemption = new("Redemption");

    public static readonly TransactionType11 ReverseRedemption = new("ReverseRedemption");

    public static readonly TransactionType11 Rebate = new("Rebate");

    public static readonly TransactionType11 ReverseRebate = new("ReverseRebate");

    public static TransactionType11 FromValue(string value) => FromValueCore(value);
}
