using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record CreateTestCardRangesResult
{
    /// <summary>
    /// The results of the test card creation.
    /// </summary>
    [JsonPropertyName("rangeCreationResults")]
    public required IReadOnlyList<TestCardRangeCreationResult> RangeCreationResults { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
