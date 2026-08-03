using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LoyaltyAccount12
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
