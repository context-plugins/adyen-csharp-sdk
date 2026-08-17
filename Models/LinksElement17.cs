using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The merchant account that the webhook is configured for. Only present for merchant-level webhooks.
/// </summary>
public record LinksElement17
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
