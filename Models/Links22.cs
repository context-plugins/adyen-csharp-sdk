using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains links to the next and previous page whenever applicable.
/// </summary>
public record Links22
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next")]
    public Next? Next { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prev")]
    public Prev? Prev { get; init; }
}
