using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>nyce</b>.
/// </summary>
public record NyceUpdateInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
