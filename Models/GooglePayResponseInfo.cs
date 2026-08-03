using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GooglePayResponseInfo
{
    /// <summary>
    /// Google Pay [Merchant ID]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantId")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// Indicates whether the Google Pay Merchant ID is used for several merchant accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reuseMerchantId")]
    public bool? ReuseMerchantId { get; init; }
}
