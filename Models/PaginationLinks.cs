using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaginationLinks
{
    [JsonPropertyName("first")]
    public required First First { get; init; }

    [JsonPropertyName("last")]
    public required Last Last { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next")]
    public Next? Next { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prev")]
    public Prev? Prev { get; init; }

    [JsonPropertyName("self")]
    public required Self Self { get; init; }
}
