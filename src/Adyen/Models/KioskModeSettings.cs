using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record KioskModeSettings
{
    /// <summary>
    /// List of package names for apps allowed to run in kiosk mode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedAppsInKioskMode")]
    public IReadOnlyList<string>? AllowedAppsInKioskMode { get; init; }

    /// <summary>
    /// The package name of the app to launch on startup. This must be one of the apps included in <c>allowedAppsInKioskMode</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kioskAppOnStartup")]
    public string? KioskAppOnStartup { get; init; }
}
