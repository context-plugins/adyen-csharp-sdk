using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>discover</b>. details
/// </summary>
public record DiscoverResponseInfo1
{
    /// <summary>
    /// Information regarding the transaction description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionResponseInfo1? TransactionDescription { get; init; }
}
