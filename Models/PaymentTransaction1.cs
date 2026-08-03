using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Data related to the payment and loyalty transaction.
/// </summary>
public record PaymentTransaction1
{
    [JsonPropertyName("AmountsReq")]
    public required AmountsReq1 AmountsReq { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OriginalPOITransaction")]
    public OriginalPoitransaction3? OriginalPoitransaction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TransactionConditions")]
    public TransactionConditions1? TransactionConditions { get; init; }
}
