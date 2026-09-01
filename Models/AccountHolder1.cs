using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record AccountHolder1
{
    /// <summary>
    /// Full name of the account holder.
    /// </summary>
    [JsonPropertyName("fullName")]
    [MinLength(1)]
    public required string FullName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
