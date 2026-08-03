using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LoyaltyAccountReq
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionReference")]
    public CardAcquisitionReference? CardAcquisitionReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccountID")]
    public LoyaltyAccountId3? LoyaltyAccountId { get; init; }
}
