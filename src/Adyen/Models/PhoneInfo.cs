using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PhoneInfo
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
