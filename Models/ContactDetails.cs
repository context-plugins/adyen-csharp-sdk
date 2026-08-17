using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ContactDetails
{
    /// <summary>
    /// The address of the account holder.
    /// </summary>
    [JsonPropertyName("address")]
    public required Address Address { get; init; }

    /// <summary>
    /// The email address of the account holder.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// The phone number of the account holder.
    /// </summary>
    [JsonPropertyName("phone")]
    public required Phone31 Phone { get; init; }

    /// <summary>
    /// The URL of the account holder's website.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddress")]
    public string? WebAddress { get; init; }
}
