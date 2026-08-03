using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SelocalAccountIdentification
{
    /// <summary>
    /// The 7- to 10-digit bank account number (<see href="https://sv.wikipedia.org/wiki/Bankkonto">Bankkontonummer</see>), without the clearing number, separators, or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(10, MinimumLength = 7)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The 4- to 5-digit clearing number (<see href="https://sv.wikipedia.org/wiki/Clearingnummer">Clearingnummer</see>), without separators or whitespace.
    /// </summary>
    [JsonPropertyName("clearingNumber")]
    [StringLength(5, MinimumLength = 4)]
    public required string ClearingNumber { get; init; }

    /// <summary>
    /// <b>seLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type264 Type { get; init; }
}
