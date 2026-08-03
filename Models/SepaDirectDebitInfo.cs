using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SepaDirectDebitInfo
{
    /// <summary>
    /// Creditor id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creditorId")]
    public string? CreditorId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
