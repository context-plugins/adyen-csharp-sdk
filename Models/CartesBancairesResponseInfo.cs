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

    /// <summary>
    /// Information regarding the transaction description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionResponseInfo1? TransactionDescription { get; init; }
}
