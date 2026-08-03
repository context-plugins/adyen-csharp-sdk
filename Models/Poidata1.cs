using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Data related to the POI System.
/// </summary>
public record Poidata1
{
    [JsonPropertyName("POITransactionID")]
    public required PoitransactionId PoitransactionId { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// If Result is Success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIReconciliationID")]
    public int? PoireconciliationId { get; init; }
}
