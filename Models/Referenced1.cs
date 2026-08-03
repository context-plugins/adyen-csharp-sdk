using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for referenced refunds.
/// </summary>
public record Referenced1
{
    /// <summary>
    /// Indicates whether referenced refunds are enabled on the standalone terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableStandaloneRefunds")]
    public bool? EnableStandaloneRefunds { get; init; }
}
