using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// List of merchant ID and acquirer ID pairs, and the operation.
/// <para>
/// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
/// </para>
/// </summary>
public record MerchantsRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// List of merchant ID and acquirer ID pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<MerchantAcquirerPair>? Value { get; init; }
}
