using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// References to resources connected with this webhook.
/// </summary>
public record WebhookLinks2
{
    /// <summary>
    /// The company account that the webhook is configured for. Only present for company-level webhooks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public LinksElement15? Company { get; init; }

    /// <summary>
    /// Generate an HMAC key.
    /// </summary>
    [JsonPropertyName("generateHmac")]
    public required LinksElement16 GenerateHmac { get; init; }

    /// <summary>
    /// The merchant account that the webhook is configured for. Only present for merchant-level webhooks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public LinksElement17? Merchant { get; init; }

    /// <summary>
    /// Link to the resource itself.
    /// </summary>
    [JsonPropertyName("self")]
    public required LinksElement6 Self { get; init; }

    /// <summary>
    /// Test the webhook setup.
    /// </summary>
    [JsonPropertyName("testWebhook")]
    public required LinksElement19 TestWebhook { get; init; }
}
