using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PayByBankPlaidUpdateInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
