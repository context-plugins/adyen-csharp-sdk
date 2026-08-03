using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Data related to a requested Loyalty program or account.
/// </summary>
public record LoyaltyAccountReq2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionReference")]
    public CardAcquisitionReference? CardAcquisitionReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccountID")]
    public LoyaltyAccountId3? LoyaltyAccountId { get; init; }
}
