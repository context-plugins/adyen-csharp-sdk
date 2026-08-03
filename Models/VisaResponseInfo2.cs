using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>visa</b> details
/// </summary>
public record VisaResponseInfo2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
