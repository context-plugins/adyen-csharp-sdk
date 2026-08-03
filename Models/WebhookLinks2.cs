using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// References to resources connected with this webhook.
/// </summary>
public record WebhookLinks2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public Company4? Company { get; init; }

    [JsonPropertyName("generateHmac")]
    public required GenerateHmac GenerateHmac { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public Merchant1? Merchant { get; init; }

    [JsonPropertyName("self")]
    public required Self Self { get; init; }

    [JsonPropertyName("testWebhook")]
    public required TestWebhook TestWebhook { get; init; }
}
