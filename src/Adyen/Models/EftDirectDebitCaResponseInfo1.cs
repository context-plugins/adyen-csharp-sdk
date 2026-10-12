using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>eft_directdebit_CA</b> (EFT PAD) details
/// </summary>
public record EftDirectDebitCaResponseInfo1
{
    /// <summary>
    /// Information regarding the transaction description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionResponseInfo1? TransactionDescription { get; init; }
}
