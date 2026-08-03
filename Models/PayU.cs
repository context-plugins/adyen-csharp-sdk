using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PayU
{
    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailReference")]
    public string? RecurringDetailReference { get; init; }

    /// <summary>
    /// Base64-encoded JSON object containing SDK related parameters required by the SDK
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    [MaxLength(50000)]
    public string? SdkData { get; init; }

    /// <summary>
    /// The <c>shopperNotificationReference</c> returned in the response when you requested to notify the shopper. Used for recurring payment only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperNotificationReference")]
    public string? ShopperNotificationReference { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    [MaxLength(64)]
    public string? StoredPaymentMethodId { get; init; }

    /// <summary>
    /// <b>payu_IN_upi</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type77 Type { get; init; }

    /// <summary>
    /// The virtual payment address for UPI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("virtualPaymentAddress")]
    public string? VirtualPaymentAddress { get; init; }
}
