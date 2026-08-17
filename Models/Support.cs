using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Support
{
    /// <summary>
    /// The support email address of the legal entity. Required if you have a platform setup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The support phone number of the legal entity. Required if you have a platform setup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public PhoneNumber1? Phone { get; init; }
}
