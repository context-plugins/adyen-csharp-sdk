using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Poidata2
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
