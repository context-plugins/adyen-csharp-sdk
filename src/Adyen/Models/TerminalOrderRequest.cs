using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalOrderRequest
{
    /// <summary>
    /// The identification of the billing entity to use for the order.
    /// <para>
    ///  &gt; When ordering products in Brazil, you do not need to include the <c>billingEntityId</c> in the request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingEntityId")]
    public string? BillingEntityId { get; init; }

    /// <summary>
    /// The merchant-defined purchase order reference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerOrderReference")]
    public string? CustomerOrderReference { get; init; }

    /// <summary>
    /// The products included in the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<OrderItem>? Items { get; init; }

    /// <summary>
    /// Type of order
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderType")]
    public string? OrderType { get; init; }

    /// <summary>
    /// The identification of the shipping location to use for the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingLocationId")]
    public string? ShippingLocationId { get; init; }

    /// <summary>
    /// The tax number of the billing entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxId")]
    public string? TaxId { get; init; }
}
