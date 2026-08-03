using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ContactDetails
{
    [JsonPropertyName("address")]
    public required Address112 Address { get; init; }

    /// <summary>
    /// The email address of the account holder.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("phone")]
    public required Phone Phone { get; init; }

    /// <summary>
    /// The URL of the account holder's website.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddress")]
    public string? WebAddress { get; init; }
}
