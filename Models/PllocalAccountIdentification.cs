using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PllocalAccountIdentification
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
    public required Type256 Type { get; init; }
}
