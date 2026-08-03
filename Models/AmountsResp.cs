using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record AmountsResp
{
    /// <summary>
    /// Currency of a monetary amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Currency")]
    [RegularExpression("^[A-Z]{3,3}$")]
    public string? Currency { get; init; }

    /// <summary>
    /// Amount requested by the Sale for the payment.
    /// </summary>
    [JsonPropertyName("AuthorizedAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public required double AuthorizedAmount { get; init; }

    /// <summary>
    /// Sum of rebates in amount (total amount or line item amount) for all the loyalty programs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalRebatesAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? TotalRebatesAmount { get; init; }

    /// <summary>
    /// Total amount of financial fees.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalFeesAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? TotalFeesAmount { get; init; }

    /// <summary>
    /// The cash-back part of the amount requested by the Sale for the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CashBackAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? CashBackAmount { get; init; }

    /// <summary>
    /// Amount paid for a tip. Allow the printing of the tip on the receipt, and to qualify the tip part of the amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TipAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? TipAmount { get; init; }
}
