using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CartesBancairesInfo
{
    /// <summary>
    /// Cartes Bancaires SIRET. Format: 14 digits.
    /// </summary>
    [JsonPropertyName("siret")]
    public required string Siret { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
