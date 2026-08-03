using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Links
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel")]
    public Href? Cancel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public Href? Success { get; init; }
}
