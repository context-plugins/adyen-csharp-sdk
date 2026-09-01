using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record DisputeServiceResult
{
    /// <summary>
    /// The general error message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; init; }

    /// <summary>
    /// Indicates whether the request succeeded.
    /// </summary>
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
