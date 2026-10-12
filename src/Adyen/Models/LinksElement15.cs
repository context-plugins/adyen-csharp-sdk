using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// The company account that the webhook is configured for. Only present for company-level webhooks.
/// </summary>
public record LinksElement15
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
