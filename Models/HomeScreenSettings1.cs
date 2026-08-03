using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for the home screen.
/// </summary>
public record HomeScreenSettings1
{
    /// <summary>
    /// Hide/show the navigation bar.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hideNavigationBar")]
    public bool? HideNavigationBar { get; init; }

    /// <summary>
    /// Show/hide the payments menu.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showPaymentsMenu")]
    public bool? ShowPaymentsMenu { get; init; }

    /// <summary>
    /// Show/hide the settings menu.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showSettingsMenu")]
    public bool? ShowSettingsMenu { get; init; }
}
