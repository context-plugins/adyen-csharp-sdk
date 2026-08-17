using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the Reconciliation transaction processed by the POI System.
/// Content of the Reconciliation Response message.
/// </summary>
public record ReconciliationResponse
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Type of Reconciliation requested by the Sale to the POI.
    /// Possible values:
    /// * <b>AcquirerReconciliation</b>
    /// * <b>AcquirerSynchronisation</b>
    /// * <b>PreviousReconciliation</b>
    /// * <b>SaleReconciliation</b>
    /// </summary>
    [JsonPropertyName("ReconciliationType")]
    public required ReconciliationType1 ReconciliationType { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// Absent if ReconciliationType is <c>AcquirerReconciliation</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIReconciliationID")]
    public int? PoiReconciliationId { get; init; }

    /// <summary>
    /// Result of the Sale to POI Reconciliation processing.
    /// If <c>Response.Result</c> is Success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TransactionTotals")]
    public IReadOnlyList<TransactionTotals>? TransactionTotals { get; init; }
}
