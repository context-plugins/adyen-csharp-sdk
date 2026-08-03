using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Support information for the legal entity. Required if you have a platform setup.
/// </summary>
public record Support1
{
    /// <summary>
    /// The support email address of the legal entity. Required if you have a platform setup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; init; }
}
