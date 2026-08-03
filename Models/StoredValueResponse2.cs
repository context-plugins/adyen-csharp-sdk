using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Stored Value Response message.
/// </summary>
public record StoredValueResponse2
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    [JsonPropertyName("POIData")]
    public required Poidata2 Poidata { get; init; }

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
