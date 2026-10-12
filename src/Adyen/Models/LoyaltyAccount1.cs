using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Data related to a loyalty account processed in the transaction.
/// </summary>
public record LoyaltyAccount1
{
    /// <summary>
    /// Identification of a Loyalty account.
    /// </summary>
    [JsonPropertyName("LoyaltyAccountID")]
    public required LoyaltyAccountId2 LoyaltyAccountId { get; init; }

    /// <summary>
    /// Identification of a Loyalty brand.
    /// If a card is analysed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyBrand")]
    [RegularExpression("^.+$")]
    public string? LoyaltyBrand { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
