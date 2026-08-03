using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>star</b>.
/// </summary>
public record StarUpdateInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
