using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DklocalAccountIdentification
{
    /// <summary>
    /// The 4-10 digits bank account number (Kontonummer) (without separators or whitespace).
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(10, MinimumLength = 4)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The 4-digit bank code (Registreringsnummer) (without separators or whitespace).
    /// </summary>
    [JsonPropertyName("bankCode")]
    [StringLength(4, MinimumLength = 4)]
    public required string BankCode { get; init; }

    /// <summary>
    /// <b>dkLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type173 Type { get; init; }
}
