using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PayToInfo
{
    /// <summary>
    /// Merchant name displayed to the shopper in the Agreements
    /// </summary>
    [JsonPropertyName("merchantName")]
    public required string MerchantName { get; init; }

    /// <summary>
    /// Represents the purpose of the Agreements created, it relates to the business type
    /// <b>Allowed values</b>: mortgage, utility, loan, gambling, retail, salary, personal, government, pension, tax, other
    /// </summary>
    [JsonPropertyName("payToPurpose")]
    public required string PayToPurpose { get; init; }
}
