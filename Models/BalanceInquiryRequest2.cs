using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Balance Inquiry Request message.
/// </summary>
public record BalanceInquiryRequest2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAccountReq")]
    public PaymentAccountReq? PaymentAccountReq { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccountReq")]
    public LoyaltyAccountReq? LoyaltyAccountReq { get; init; }
}
