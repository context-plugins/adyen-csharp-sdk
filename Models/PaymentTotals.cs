using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Totals of the payment transaction during the reconciliation period.
/// </summary>
public record PaymentTotals
{
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
