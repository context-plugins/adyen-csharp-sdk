using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>girocard</b> details
/// </summary>
public record GirocardResponseInfo1
{
    /// <summary>
    /// Information regarding the transaction description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionResponseInfo1? TransactionDescription { get; init; }
}
