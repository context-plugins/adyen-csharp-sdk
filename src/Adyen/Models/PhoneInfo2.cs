using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The information about the phone number of the device used to provision the the network token. This object is conditionally returned and is available for up to 24 hours after the provisioning request (access to this field requires a specific user role, please contact your Adyen representative to request permission).
/// </summary>
public record PhoneInfo2
{
    /// <summary>
    /// The hashed value of the phone number used to provision the network token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hashedNumber")]
    public string? HashedNumber { get; init; }

    /// <summary>
    /// The last four digits of the phone number used to provision the network token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastFourDigits")]
    public string? LastFourDigits { get; init; }

    /// <summary>
    /// The full phone number of the device used to provision the network token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }
}
