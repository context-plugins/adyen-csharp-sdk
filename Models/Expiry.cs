using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Expiry
{
    /// <summary>
    /// The month in which the card will expire.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("month")]
    public string? Month { get; init; }

    /// <summary>
    /// The year in which the card will expire.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("year")]
    public string? Year { get; init; }
}
