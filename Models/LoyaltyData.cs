using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// In the Payment, Loyalty or Balance Inquiry Request message, it allows the Sale Terminal to send the identification of the loyalty account or an awarded amount or an amount to redeem to the loyalty account.
/// Data related to a Loyalty program or account.
/// </summary>
public record LoyaltyData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionReference")]
    public CardAcquisitionReference? CardAcquisitionReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccountID")]
    public LoyaltyAccountId3? LoyaltyAccountId { get; init; }
}
