using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>eft_directdebit_CA</b> (EFT PAD) details
/// </summary>
public record EftdirectDebitCaresponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
