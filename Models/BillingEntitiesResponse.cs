using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BillingEntitiesResponse
{
    /// <summary>
    /// List of legal entities that can be used for the billing of orders.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<BillingEntity>? Data { get; init; }
}
