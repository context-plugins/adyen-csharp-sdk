using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardOrderItem
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balancePlatform")]
    public string? BalancePlatform { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public CardOrderItemDeliveryStatus? Card { get; init; }

    /// <summary>
    /// The unique identifier of the card order item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardOrderItemId")]
    public string? CardOrderItemId { get; init; }

    /// <summary>
    /// The date and time when the event was triggered, in ISO 8601 extended format. For example, <b>2025-03-19T10:15:30+01:00</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creationDate")]
    public DateTimeOffset? CreationDate { get; init; }

    /// <summary>
    /// The ID of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument related to the card order item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrumentId")]
    public string? PaymentInstrumentId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pin")]
    public CardOrderItemDeliveryStatus? Pin { get; init; }

    /// <summary>
    /// The shipping method used to deliver the card or the PIN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingMethod")]
    public string? ShippingMethod { get; init; }
}
