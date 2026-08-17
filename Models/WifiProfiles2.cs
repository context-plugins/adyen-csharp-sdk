using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Remote Wi-Fi profiles for WPA and WPA2 PSK and EAP Wi-Fi networks.
/// </summary>
public record WifiProfiles2
{
    /// <summary>
    /// List of remote Wi-Fi profiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profiles")]
    public IReadOnlyList<Profile>? Profiles { get; init; }

    /// <summary>
    /// General Wi-Fi settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    public Settings1? Settings { get; init; }
}
