using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>eftpos_australia</b> details
/// </summary>
public record EftPosAustraliaResponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
