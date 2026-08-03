using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>mc</b> details
/// </summary>
public record McresponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
