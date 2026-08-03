using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LoyaltyAcquirerData
{
    /// <summary>
    /// Identification of the loyalty Acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAcquirerID")]
    [RegularExpression("^.+$")]
    public string? LoyaltyAcquirerId { get; init; }

    /// <summary>
    /// Code assigned to a transaction approval by the Acquirer. Could be an identifier of the approved transaction for the Acquirer. This data element is conditional for the Loyalty Acquirers. Used in the PaymentRequest request for a referral.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ApprovalCode")]
    [RegularExpression("^.+$")]
    public string? ApprovalCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyTransactionID")]
    public LoyaltyTransactionId? LoyaltyTransactionId { get; init; }

    /// <summary>
    /// Identifier of a reconciliation period with a payment or loyalty host. Allows the assignment of a transaction to the Acquirer reconciliation (or batch).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("HostReconciliationID")]
    [RegularExpression("^.+$")]
    public string? HostReconciliationId { get; init; }
}
