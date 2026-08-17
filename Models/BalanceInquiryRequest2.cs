using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Balance Inquiry Request message.
/// </summary>
public record BalanceInquiryRequest2
{
    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAccountReq")]
    public PaymentAccountReq2? PaymentAccountReq { get; init; }

    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccountReq")]
    public LoyaltyAccountReq2? LoyaltyAccountReq { get; init; }
}
