using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UtilityResponse
{
    /// <summary>
    /// The list of origin keys for all requested domains. For each list item, the key is the domain and the value is the origin key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originKeys")]
    public IReadOnlyDictionary<string, string>? OriginKeys { get; init; }
}
