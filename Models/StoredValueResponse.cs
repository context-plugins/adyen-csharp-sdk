using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the Stored Value transaction processed by the POI System.
/// Content of the Stored Value Response message.
/// </summary>
public record StoredValueResponse
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Data related to the Sale System.
    /// </summary>
    [JsonPropertyName("SaleData")]
    public required SaleData1 SaleData { get; init; }

    /// <summary>
    /// Data related to the POI System.
    /// </summary>
    [JsonPropertyName("POIData")]
    public required PoiData1 PoiData { get; init; }

    /// <summary>
    /// Result of loading/reloading a stored value card.
    /// If StoredValueResponse.Result is Success or Partial, one entry per StoredValueRequest.StoredValueData loaded or activated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueResult")]
    public IReadOnlyList<StoredValueResult>? StoredValueResult { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentReceipt")]
    public IReadOnlyList<PaymentReceipt>? PaymentReceipt { get; init; }
}
