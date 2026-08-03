using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CheckoutOrderResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount16? Amount { get; init; }

    /// <summary>
    /// The expiry date for the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiresAt")]
    public string? ExpiresAt { get; init; }

    /// <summary>
    /// The encrypted order data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderData")]
    public string? OrderData { get; init; }

    /// <summary>
    /// The <c>pspReference</c> that belongs to the order.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }

    /// <summary>
    /// The merchant reference for the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remainingAmount")]
    public RemainingAmount? RemainingAmount { get; init; }
}
