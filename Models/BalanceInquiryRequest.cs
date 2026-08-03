using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the account for which a Balance Inquiry is requested.
/// Content of the Balance Inquiry Request message.
/// </summary>
public record BalanceInquiryRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAccountReq")]
    public PaymentAccountReq? PaymentAccountReq { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccountReq")]
    public LoyaltyAccountReq? LoyaltyAccountReq { get; init; }
}
