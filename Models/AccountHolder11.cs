using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the full name of the person or entity that receives the payment funds).
/// </summary>
public record AccountHolder11
{
    /// <summary>
    /// Full name of the account holder.
    /// </summary>
    [JsonPropertyName("fullName")]
    [MinLength(1)]
    public required string FullName { get; init; }
}
