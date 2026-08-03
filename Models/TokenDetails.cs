using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TokenDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenData")]
    public IReadOnlyDictionary<string, string>? TokenData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenDataType")]
    public string? TokenDataType { get; init; }
}
