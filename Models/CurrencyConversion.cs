using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// Information related to a currency conversion.
/// A currency conversion occurred in the payment, and the merchant needs to know information related to this conversion (e.g. to print on the sale receipt).
/// </summary>
public record CurrencyConversion
{
    /// <summary>
    /// Notify if the customer has approved something. Indicates if the customer has accepted a currency conversion.
    /// </summary>
    [JsonPropertyName("CustomerApprovedFlag")]
    public bool? CustomerApprovedFlag { get; init; } = true;

    [JsonPropertyName("ConvertedAmount")]
    public required ConvertedAmount ConvertedAmount { get; init; }

    /// <summary>
    /// Rate of currency conversion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Rate")]
    public double? Rate { get; init; }

    /// <summary>
    /// Markup of a currency conversion amount as a percentage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Markup")]
    public double? Markup { get; init; }

    /// <summary>
    /// Commission for a currency conversion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Commission")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? Commission { get; init; }

    /// <summary>
    /// Declaration to present to the customer or the cashier for validation.
    /// If a declaration has to be presented to the customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Declaration")]
    [RegularExpression("^.+$")]
    public string? Declaration { get; init; }
}
