using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record RoutingDetails
{
    /// <summary>
    /// A human-readable explanation specific to this occurrence of the problem.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detail")]
    public string? Detail { get; init; }

    /// <summary>
    /// A code that identifies the problem type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    public Priority? Priority { get; init; }

    /// <summary>
    /// A short, human-readable summary of the problem type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }
}
