using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The name of the contact.
/// </summary>
public record Name2
{
    /// <summary>
    /// The first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    [MaxLength(80)]
    public required string FirstName { get; init; }

    /// <summary>
    /// The last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    [MaxLength(80)]
    public required string LastName { get; init; }
}
