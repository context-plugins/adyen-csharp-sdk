using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MerchantNamesRestriction
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<StringMatch>? Value { get; init; }
}
