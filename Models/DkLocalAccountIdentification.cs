using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record DkLocalAccountIdentification
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
    public string Type { get; } = "dkLocal";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
