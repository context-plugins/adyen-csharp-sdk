using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>cup</b> (China Union Pay) details
/// </summary>
public record CupResponseInfo1
{
    /// <summary>
    /// Information regarding the transaction description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionResponseInfo1? TransactionDescription { get; init; }
}
