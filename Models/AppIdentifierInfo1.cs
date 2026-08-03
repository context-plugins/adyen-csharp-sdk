using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The app identifier information containing iOS scheme and Android package ID.
/// </summary>
public record AppIdentifierInfo1
{
    /// <summary>
    /// The Android package identifier for this app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("androidPackageId")]
    public string? AndroidPackageId { get; init; }

    /// <summary>
    /// The iOS URL scheme for this app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iosScheme")]
    public string? IosScheme { get; init; }
}
