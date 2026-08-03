using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BalanceInquiryRequest3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAccountReq")]
    public PaymentAccountReq? PaymentAccountReq { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccountReq")]
    public LoyaltyAccountReq? LoyaltyAccountReq { get; init; }
}
