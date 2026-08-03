using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record WifiProfiles
{
    /// <summary>
    /// List of remote Wi-Fi profiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profiles")]
    public IReadOnlyList<Profile>? Profiles { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    public Settings? Settings { get; init; }
}
