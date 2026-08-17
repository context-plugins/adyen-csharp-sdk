using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Content of the Reconciliation Request message.
/// It conveys Information related to the Reconciliation requested by the Sale System.
/// </summary>
public record ReconciliationRequest
{
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
    /// Identification of the Acquirer.
    /// Could be present only if ReconciliationType is AcquirerReconciliation or AcquirerSynchronisation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AcquirerID")]
    public IReadOnlyList<int>? AcquirerId { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// Absent if ReconciliationType is not PreviousReconciliation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIReconciliationID")]
    public int? PoiReconciliationId { get; init; }
}
