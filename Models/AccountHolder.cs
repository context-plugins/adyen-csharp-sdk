using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AccountHolder
{
    /// <summary>
    /// Full name of the account holder.
    /// </summary>
    [JsonPropertyName("fullName")]
    [MinLength(1)]
    public required string FullName { get; init; }
}
