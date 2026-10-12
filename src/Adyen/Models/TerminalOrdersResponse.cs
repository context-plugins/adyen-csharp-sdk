using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalOrdersResponse
{
    /// <summary>
    /// List of orders for payment terminal packages and parts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<TerminalOrder>? Data { get; init; }
}
