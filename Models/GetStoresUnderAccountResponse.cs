using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetStoresUnderAccountResponse
{
    /// <summary>
    /// Array that returns a list of all stores for the specified merchant account, or for all merchant accounts under the company account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stores")]
    public IReadOnlyList<Store1>? Stores { get; init; }
}
