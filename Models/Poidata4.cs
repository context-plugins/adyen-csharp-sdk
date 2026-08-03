using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Data related to the POI System.
/// If Result is Success.
/// </summary>
public record Poidata4
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
