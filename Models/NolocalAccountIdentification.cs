using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record NolocalAccountIdentification
{
    /// <summary>
    /// The 11-digit bank account number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(11, MinimumLength = 11)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// <b>noLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type223 Type { get; init; }
}
