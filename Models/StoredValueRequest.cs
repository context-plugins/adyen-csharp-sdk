using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the Stored Value transaction to process.
/// Content of the Stored Value Request message.
/// </summary>
public record StoredValueRequest
{
    /// <summary>
    /// Data related to the Sale System.
    /// </summary>
    [JsonPropertyName("SaleData")]
    public required SaleData1 SaleData { get; init; }

    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [JsonPropertyName("StoredValueData")]
    public required IReadOnlyList<StoredValueData> StoredValueData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
