using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>discover</b>. details
/// </summary>
public record DiscoverResponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
