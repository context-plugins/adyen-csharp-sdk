using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MerchantLinks
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apiCredentials")]
    public LinksElement? ApiCredentials { get; init; }

    /// <summary>
    /// Link to the resource itself.
    /// </summary>
    [JsonPropertyName("self")]
    public required LinksElement6 Self { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("users")]
    public LinksElement? Users { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhooks")]
    public LinksElement? Webhooks { get; init; }
}
