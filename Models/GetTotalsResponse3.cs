using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetTotalsResponse3
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// </summary>
    [JsonPropertyName("POIReconciliationID")]
    public required int PoireconciliationId { get; init; }

    /// <summary>
    /// Result of the Sale to POI Reconciliation processing.
    /// If <c>Response.Result</c> is Success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TransactionTotals")]
    public IReadOnlyList<TransactionTotals>? TransactionTotals { get; init; }
}
