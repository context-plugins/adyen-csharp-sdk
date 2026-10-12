using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Content of the Get Totals Response message.
/// </summary>
public record GetTotalsResponse2
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// </summary>
    [JsonPropertyName("POIReconciliationID")]
    public required int PoiReconciliationId { get; init; }

    /// <summary>
    /// Result of the Sale to POI Reconciliation processing.
    /// If <c>Response.Result</c> is Success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TransactionTotals")]
    public IReadOnlyList<TransactionTotals>? TransactionTotals { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
