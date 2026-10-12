using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the device used to provision the network token.
/// </summary>
public record DeviceInfo1
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

    /// <summary>
    /// The information about the phone number of the device used to provision the the network token. This object is conditionally returned and is available for up to 24 hours after the provisioning request (access to this field requires a specific user role, please contact your Adyen representative to request permission).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public PhoneInfo2? Phone { get; init; }
}
