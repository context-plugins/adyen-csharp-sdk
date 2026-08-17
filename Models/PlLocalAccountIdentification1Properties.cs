using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PlLocalAccountIdentification1Properties
{
    /// <summary>
    /// The 26-digit bank account number (<see href="https://pl.wikipedia.org/wiki/Numer_Rachunku_Bankowego">Numer rachunku</see>), without separators or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(26, MinimumLength = 26)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// <b>plLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "plLocal";
}
