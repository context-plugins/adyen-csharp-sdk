using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DataReviewConfirmationResponse
{
    /// <summary>
    /// Date when data review was confirmed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataReviewedAt")]
    public string? DataReviewedAt { get; init; }
}
