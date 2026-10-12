using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Data related to the POI System.
/// </summary>
public record PoiData1
{
    /// <summary>
    /// Unique identification of a POI transaction for a POI.
    /// </summary>
    [JsonPropertyName("POITransactionID")]
    public required TransactionIdType2 PoiTransactionId { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// If Result is Success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIReconciliationID")]
    public int? PoiReconciliationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
