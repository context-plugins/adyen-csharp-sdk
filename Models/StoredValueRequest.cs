using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the Stored Value transaction to process.
/// Content of the Stored Value Request message.
/// </summary>
public record StoredValueRequest
{
    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [JsonPropertyName("StoredValueData")]
    public required IReadOnlyList<StoredValueData> StoredValueData { get; init; }
}
