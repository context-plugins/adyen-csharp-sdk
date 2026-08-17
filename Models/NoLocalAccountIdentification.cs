using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record NoLocalAccountIdentification
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
    public string Type { get; } = "noLocal";
}
