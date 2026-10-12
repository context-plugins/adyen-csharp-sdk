using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>amex</b> details
/// </summary>
public record AmexResponseInfo1
{
    /// <summary>
    /// Merchant ID (MID) number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("midNumber")]
    public string? MidNumber { get; init; }

    /// <summary>
    /// Indicates whether the Amex Merchant ID is reused from a previously setup Amex payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reuseMidNumber")]
    public bool? ReuseMidNumber { get; init; }

    /// <summary>
    /// The service level (settlement type) of this payment method. Possible values:
    /// * <b>noContract</b>: Adyen holds the contract with American Express.
    /// * <b>gatewayContract</b>: American Express receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.
    /// * <b>paymentDesignatorContract</b>: Adyen receives the settlement, and handles disputes and payouts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceLevel")]
    public string? ServiceLevel { get; init; }
}
