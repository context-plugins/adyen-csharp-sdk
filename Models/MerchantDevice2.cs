using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MerchantDevice2
{
    /// <summary>
    /// Operating system running on the merchant device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("os")]
    public string? Os { get; init; }

    /// <summary>
    /// Version of the operating system on the merchant device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; init; }

    /// <summary>
    /// Merchant device reference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }
}
