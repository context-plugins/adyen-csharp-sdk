using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// List of names that will be compared to the merchant name according to the matching type.
/// <para>
/// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
/// </para>
/// </summary>
public record MerchantNamesRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<StringMatch>? Value { get; init; }
}
