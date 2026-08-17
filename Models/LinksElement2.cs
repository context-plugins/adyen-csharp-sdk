using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Company account that the API credential is linked to. Only present for company-level webhooks.
/// </summary>
public record LinksElement2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
