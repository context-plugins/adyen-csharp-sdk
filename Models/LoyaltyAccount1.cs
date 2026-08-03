using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Data related to a loyalty account processed in the transaction.
/// </summary>
public record LoyaltyAccount1
{
    [JsonPropertyName("LoyaltyAccountID")]
    public required LoyaltyAccountId3 LoyaltyAccountId { get; init; }

    /// <summary>
    /// Identification of a Loyalty brand.
    /// If a card is analysed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyBrand")]
    [RegularExpression("^.+$")]
    public string? LoyaltyBrand { get; init; }
}
