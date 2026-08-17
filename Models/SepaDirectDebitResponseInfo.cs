using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SepaDirectDebitResponseInfo
{
    /// <summary>
    /// Creditor id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creditorId")]
    public string? CreditorId { get; init; }

    /// <summary>
    /// Information regarding the transaction description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionResponseInfo1? TransactionDescription { get; init; }
}
