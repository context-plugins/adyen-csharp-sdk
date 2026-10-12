using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AffirmInfo
{
    /// <summary>
    /// Selected Affirm financing package. Choose from <b>core</b>, <b>standard</b>, or <b>signature</b>. Defaults to <b>core</b> if no selection made.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricePlan")]
    public string? PricePlan { get; init; }

    /// <summary>
    /// Merchant support email used to manage disputes.
    /// </summary>
    [JsonPropertyName("supportEmail")]
    public required string SupportEmail { get; init; }
}
