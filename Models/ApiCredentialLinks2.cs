using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// References to resources linked to the API credential.
/// </summary>
public record ApiCredentialLinks2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedOrigins")]
    public AllowedOrigins? AllowedOrigins { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public Company4? Company { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generateApiKey")]
    public GenerateApiKey? GenerateApiKey { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generateClientKey")]
    public GenerateClientKey? GenerateClientKey { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public Merchant1? Merchant { get; init; }

    [JsonPropertyName("self")]
    public required Self Self { get; init; }
}
