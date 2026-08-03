using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>cup</b> (China Union Pay) details
/// </summary>
public record CupResponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
