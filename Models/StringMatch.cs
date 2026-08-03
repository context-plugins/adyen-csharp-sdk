using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record StringMatch
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("operation")]
    public Operation? Operation { get; init; }

    /// <summary>
    /// The string to be matched.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }
}
