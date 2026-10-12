using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AppIdentifierInfo
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
