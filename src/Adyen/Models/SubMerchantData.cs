using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SubMerchantData
{
    /// <summary>
    /// The email associated with the sub-merchant's account.
    /// </summary>
    [JsonPropertyName("email")]
    [MaxLength(320)]
    public required string Email { get; init; }

    /// <summary>
    /// A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.
    /// * Format: Alphanumeric
    /// * Maximum length: 15 characters
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The sub-merchant's 4-digit Merchant Category Code (MCC).
    /// * Format: Numeric
    /// * Fixed length: 4 digits
    /// </summary>
    [JsonPropertyName("mcc")]
    public required string Mcc { get; init; }

    /// <summary>
    /// The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement that will appear in the card statement.
    /// * Format: Alphanumeric
    /// * Maximum length: 22 characters
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
