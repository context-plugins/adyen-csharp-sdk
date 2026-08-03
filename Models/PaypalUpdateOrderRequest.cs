using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaypalUpdateOrderRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount16? Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddress")]
    public DeliveryAddress1? DeliveryAddress { get; init; }

    /// <summary>
    /// The list of new delivery methods and the cost of each.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryMethods")]
    public IReadOnlyList<DeliveryMethod>? DeliveryMethods { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountAmount")]
    public DiscountAmount? DiscountAmount { get; init; }

    /// <summary>
    /// The <c>paymentData</c> from the client side. This value changes every time you make a <c>/paypal/updateOrder</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentData")]
    public string? PaymentData { get; init; }

    /// <summary>
    /// The original <c>pspReference</c> from the <c>/payments</c> response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// The original <c>sessionId</c> from the <c>/sessions</c> response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAmount")]
    public ShippingAmount? ShippingAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxTotal")]
    public TaxTotal? TaxTotal { get; init; }
}
