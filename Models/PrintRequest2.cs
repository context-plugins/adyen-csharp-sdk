using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Print Request message.
/// </summary>
public record PrintRequest2
{
    [JsonPropertyName("PrintOutput")]
    public required PrintOutput PrintOutput { get; init; }
}
