using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PrintRequest3
{
    [JsonPropertyName("PrintOutput")]
    public required PrintOutput PrintOutput { get; init; }
}
