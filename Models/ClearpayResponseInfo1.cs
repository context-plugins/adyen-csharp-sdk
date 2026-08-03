using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>clearpay</b> details
/// </summary>
public record ClearpayResponseInfo1
{
    /// <summary>
    /// Support Url
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; init; }
}
