using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateTestCardRangesResult
{
    /// <summary>
    /// The results of the test card creation.
    /// </summary>
    [JsonPropertyName("rangeCreationResults")]
    public required IReadOnlyList<TestCardRangeCreationResult> RangeCreationResults { get; init; }
}
