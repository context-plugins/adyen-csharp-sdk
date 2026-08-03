using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Referenced
{
    /// <summary>
    /// Indicates whether referenced refunds are enabled on the standalone terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableStandaloneRefunds")]
    public bool? EnableStandaloneRefunds { get; init; }
}
