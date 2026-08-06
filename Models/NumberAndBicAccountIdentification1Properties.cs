using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record NumberAndBicAccountIdentification1Properties
{
    /// <summary>
    /// The bank account number, without separators or whitespace. The length and format depends on the bank or country.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [MaxLength(34)]
    public required string AccountNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalBankIdentification")]
    public AdditionalBankIdentification? AdditionalBankIdentification { get; init; }

    /// <summary>
    /// The bank's 8- or 11-character BIC or SWIFT code.
    /// </summary>
    [JsonPropertyName("bic")]
    [StringLength(11, MinimumLength = 8)]
    public required string Bic { get; init; }

    /// <summary>
    /// <b>numberAndBic</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
