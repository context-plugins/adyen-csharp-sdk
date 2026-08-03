using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>interac_card</b> details
/// </summary>
public record InteracCardResponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
