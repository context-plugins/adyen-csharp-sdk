using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CheckoutForwardResponse
{
    /// <summary>
    /// Merchant defined payment reference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// Adyen's 16-character reference associated with the transaction/request. This value is globally unique. Use this reference when you communicate with us about this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    [JsonPropertyName("response")]
    public required CheckoutForwardResponseFromUrl Response { get; init; }

    /// <summary>
    /// The unique identifier of the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    public string? StoredPaymentMethodId { get; init; }
}
