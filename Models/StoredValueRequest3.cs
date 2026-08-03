using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record StoredValueRequest3
{
    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [JsonPropertyName("StoredValueData")]
    public required IReadOnlyList<StoredValueData> StoredValueData { get; init; }
}
