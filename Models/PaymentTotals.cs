using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Totals of the payment transaction during the reconciliation period.
/// </summary>
public record PaymentTotals
{
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
    [JsonPropertyName("TransactionType")]
    public required TransactionType11 TransactionType { get; init; }

    /// <summary>
    /// Number of processed transaction during the period.
    /// </summary>
    [JsonPropertyName("TransactionCount")]
    public required int TransactionCount { get; init; }

    /// <summary>
    /// Sum of amount of processed transaction during the period.
    /// </summary>
    [JsonPropertyName("TransactionAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public required double TransactionAmount { get; init; }
}
