using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record EncryptedOrderData
{
    /// <summary>
    /// The encrypted order data.
    /// </summary>
    [JsonPropertyName("orderData")]
    [MaxLength(5000)]
    public required string OrderData { get; init; }

    /// <summary>
    /// The <c>pspReference</c> that belongs to the order.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }
}
