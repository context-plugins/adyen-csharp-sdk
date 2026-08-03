using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SplitConfigurationList
{
    /// <summary>
    /// List of split configurations applied to the stores under the merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<SplitConfiguration>? Data { get; init; }
}
