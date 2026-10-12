using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AmexInfo
{
    /// <summary>
    /// Merchant ID (MID) number. Format: 10 numeric characters.
    ///  You must provide this field when you request <c>gatewayContract</c> or <c>paymentDesignatorContract</c> service levels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("midNumber")]
    [MaxLength(10)]
    public string? MidNumber { get; init; }

    /// <summary>
    /// Indicates whether the Amex Merchant ID is reused from a previously setup Amex payment method.
    /// This is only applicable for <c>gatewayContract</c> and <c>paymentDesignatorContract</c> service levels.
    /// The default value is <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reuseMidNumber")]
    public bool? ReuseMidNumber { get; init; } = false;

    /// <summary>
    /// Specifies the service level (settlement type) of this payment method. Possible values:
    /// * <b>noContract</b>: Adyen holds the contract with American Express.
    /// * <b>gatewayContract</b>: American Express receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.
    /// * <b>paymentDesignatorContract</b>: Adyen receives the settlement, and handles disputes and payouts.
    /// </summary>
    [JsonPropertyName("serviceLevel")]
    public required ServiceLevel ServiceLevel { get; init; }
}
