using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The order request object that contains a pspReference that represents the order and the matching encrypted order data.
/// </summary>
public record EncryptedOrderData4
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
