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
public sealed record TransactionType1 : StringEnum<TransactionType1>
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

    public static TransactionType1 FromValue(string value) => FromValueCore(value);
}
