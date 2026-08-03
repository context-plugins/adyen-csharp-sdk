using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransferRouteResponse
{
    /// <summary>
    /// List of available priorities for a transfer, along with requirements. Use this information to initiate a transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferRoutes")]
    public IReadOnlyList<TransferRoute>? TransferRoutes { get; init; }
}
