using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Links3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next")]
    public Next? Next { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prev")]
    public Prev? Prev { get; init; }
}
