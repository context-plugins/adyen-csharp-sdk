using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentTransaction
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
