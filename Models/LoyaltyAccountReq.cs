using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LoyaltyAccountReq
{
    /// <summary>
    /// Identification of a transaction for the Sale System or the POI System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionReference")]
    public TransactionIdType? CardAcquisitionReference { get; init; }

    /// <summary>
    /// Identification of a Loyalty account.
    /// In the Payment Request message, it allows to identify the loyalty account by the Sale Terminal instead of the POI Terminal (e.g. because the account identification is a bar-code read by the Cashier on a scanner device).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccountID")]
    public LoyaltyAccountId? LoyaltyAccountId { get; init; }
}
