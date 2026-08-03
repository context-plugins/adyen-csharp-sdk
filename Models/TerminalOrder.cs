using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalOrder
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingEntity")]
    public BillingEntity? BillingEntity { get; init; }

    /// <summary>
    /// The merchant-defined purchase order number. This will be printed on the packing list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerOrderReference")]
    public string? CustomerOrderReference { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The products included in the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<OrderItem>? Items { get; init; }

    /// <summary>
    /// The date and time that the order was placed, in UTC ISO 8601 format. For example, "2011-12-03T10:15:30Z".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderDate")]
    public string? OrderDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingLocation")]
    public ShippingLocation? ShippingLocation { get; init; }

    /// <summary>
    /// The processing status of the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The URL, provided by the carrier company, where the shipment can be tracked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trackingUrl")]
    public string? TrackingUrl { get; init; }
}
