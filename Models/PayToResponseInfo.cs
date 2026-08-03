using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PayToResponseInfo
{
    /// <summary>
    /// Merchant name displayed to the shopper in the Agreements
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantName")]
    public string? MerchantName { get; init; }

    /// <summary>
    /// Represents the purpose of the Agreements created, it relates to the business type
    /// <b>Allowed values</b>: mortgage, utility, loan, gambling, retail, salary, personal, government, pension, tax, other
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payToPurpose")]
    public string? PayToPurpose { get; init; }
}
