using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the account for which a Balance Inquiry is requested.
/// Content of the Balance Inquiry Request message.
/// </summary>
public record BalanceInquiryRequest
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
