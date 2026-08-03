using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ReconciliationRequest3
{
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
    public int? PoireconciliationId { get; init; }
}
