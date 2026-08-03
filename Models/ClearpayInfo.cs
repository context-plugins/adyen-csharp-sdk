using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ClearpayInfo
{
    /// <summary>
    /// Support Url
    /// </summary>
    [JsonPropertyName("supportUrl")]
    public required string SupportUrl { get; init; }
}
