using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DeviceInfo
{
    /// <summary>
    /// The type of device used to provision the network token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formFactor")]
    public string? FormFactor { get; init; }

    /// <summary>
    /// The operating system of the device used to provision the network token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("osName")]
    public string? OsName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public PhoneInfo? Phone { get; init; }
}
