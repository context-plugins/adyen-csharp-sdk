using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UninstallAndroidAppDetails
{
    /// <summary>
    /// The unique identifier of the app to be uninstalled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appId")]
    public string? AppId { get; init; }

    /// <summary>
    /// Type of terminal action: Uninstall an Android app.
    /// </summary>
    [JsonPropertyName("type")]
    public Type71? Type { get; init; } = Type71.UninstallAndroidApp;
}
