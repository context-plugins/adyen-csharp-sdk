using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CartesBancairesResponseInfo
{
    /// <summary>
    /// Cartes Bancaires SIRET. Format: 14 digits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("siret")]
    public string? Siret { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
