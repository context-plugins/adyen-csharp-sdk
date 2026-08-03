using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// General Wi-Fi settings.
/// </summary>
public record Settings1
{
    /// <summary>
    /// The preferred Wi-Fi band, for use if the terminals support multiple bands. Possible values: All, 2.4GHz, 5GHz.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("band")]
    public string? Band { get; init; }

    /// <summary>
    /// Indicates whether roaming is enabled on the terminals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roaming")]
    public bool? Roaming { get; init; }

    /// <summary>
    /// The connection time-out in seconds. Minimum value: 0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeout")]
    public int? Timeout { get; init; }
}
