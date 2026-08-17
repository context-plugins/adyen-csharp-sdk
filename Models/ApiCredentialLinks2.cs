using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// References to resources linked to the API credential.
/// </summary>
public record ApiCredentialLinks2
{
    /// <summary>
    /// List of allowed origins.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedOrigins")]
    public LinksElement1? AllowedOrigins { get; init; }

    /// <summary>
    /// Company account that the API credential is linked to. Only present for company-level webhooks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public LinksElement2? Company { get; init; }

    /// <summary>
    /// Generates a new API key. When you generate a new one, the existing key remains valid for 24 hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generateApiKey")]
    public LinksElement3? GenerateApiKey { get; init; }

    /// <summary>
    /// Generates a new client key, used to authenticate client-side requests. When you generate a new one, the existing key remains valid for 24 hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generateClientKey")]
    public LinksElement4? GenerateClientKey { get; init; }

    /// <summary>
    /// The merchant account that the API credential is linked to. Only present for merchant-level API credentials.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public LinksElement5? Merchant { get; init; }

    /// <summary>
    /// Link to the resource itself.
    /// </summary>
    [JsonPropertyName("self")]
    public required LinksElement6 Self { get; init; }
}
