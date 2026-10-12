using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ClearpayResponseInfo
{
    /// <summary>
    /// Support Url
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; init; }
}
