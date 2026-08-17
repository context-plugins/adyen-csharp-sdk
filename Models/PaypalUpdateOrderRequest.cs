using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaypalUpdateOrderRequest
{
    /// <summary>
    /// The updated final payment amount. This amount is the item total plus the shipping costs of the selected <c>deliveryMethod</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount44? Amount { get; init; }

    /// <summary>
    /// The delivery address for this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddress")]
    public DeliveryAddress5? DeliveryAddress { get; init; }

    /// <summary>
    /// The list of new delivery methods and the cost of each.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryMethods")]
    public IReadOnlyList<DeliveryMethod>? DeliveryMethods { get; init; }

    /// <summary>
    /// The discount amount for this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountAmount")]
    public Amount45? DiscountAmount { get; init; }

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

    /// <summary>
    /// The shipping amount for this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAmount")]
    public Amount46? ShippingAmount { get; init; }

    /// <summary>
    /// Total tax amount from the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxTotal")]
    public TaxTotal2? TaxTotal { get; init; }
}
