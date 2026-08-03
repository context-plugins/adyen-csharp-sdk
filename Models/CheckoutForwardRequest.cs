using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CheckoutForwardRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount16? Amount { get; init; }

    /// <summary>
    /// The base URL of the third party API, where Adyen will send the request to forward the payment details.
    /// </summary>
    [JsonPropertyName("baseUrl")]
    public required string BaseUrl { get; init; }

    /// <summary>
    /// Your merchant account.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// Merchant defined payment reference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public CheckoutForwardRequestOptions? Options { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public CheckoutForwardRequestCard? PaymentMethod { get; init; }

    [JsonPropertyName("request")]
    public required CheckoutOutgoingForwardRequest Request { get; init; }

    /// <summary>
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.
    /// &gt; Your reference must not include personally identifiable information (PII) such as name or email address.
    /// </summary>
    [JsonPropertyName("shopperReference")]
    public required string ShopperReference { get; init; }

    /// <summary>
    /// The unique identifier of the token that you want to forward to the third party. This is the <c>storedPaymentMethodId</c> you received in the webhook after you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    public string? StoredPaymentMethodId { get; init; }
}
