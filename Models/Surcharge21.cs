using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for payment <see href="https://docs.adyen.com/point-of-sale/surcharge">surcharge</see> features.
/// </summary>
public record Surcharge21
{
    /// <summary>
    /// Show the surcharge details on the terminal, so the shopper can confirm.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("askConfirmation")]
    public bool? AskConfirmation { get; init; }

    /// <summary>
    /// Surcharge fees or percentages for specific cards, funding sources (credit or debit), and currencies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configurations")]
    public IReadOnlyList<ConfigurationModel>? Configurations { get; init; }

    /// <summary>
    /// Show the maximum surcharge rate to the shopper on the present card screen before they tap.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disclosureOnPresentCard")]
    public bool? DisclosureOnPresentCard { get; init; }

    /// <summary>
    /// Exclude the tip amount from the surcharge calculation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excludeGratuityFromSurcharge")]
    public bool? ExcludeGratuityFromSurcharge { get; init; }
}
