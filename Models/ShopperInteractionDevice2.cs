using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ShopperInteractionDevice2
{
    /// <summary>
    /// Locale on the shopper interaction device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// Operating system running on the shopper interaction device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("os")]
    public string? Os { get; init; }

    /// <summary>
    /// Version of the operating system on the shopper interaction device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; init; }
}
