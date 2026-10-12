using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// In the Payment, Loyalty or Balance Inquiry Request message, it allows the Sale Terminal to send the identification of the loyalty account or an awarded amount or an amount to redeem to the loyalty account.
/// Data related to a Loyalty program or account.
/// </summary>
public record LoyaltyData
{
    /// <summary>
    /// Reference to the last CardAcquisition, to use the same card.
    /// If the loyalty account ID comes from a previous CardAcquisition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionReference")]
    public TransactionIdType3? CardAcquisitionReference { get; init; }

    /// <summary>
    /// Identification of a Loyalty account.
    /// If loyalty identification of the loyalty account is realised by the Sale System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccountID")]
    public LoyaltyAccountId1? LoyaltyAccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
