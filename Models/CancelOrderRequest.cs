using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CancelOrderRequest
{
    /// <summary>
    /// The merchant account identifier that orderData belongs to.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The order request object that contains a pspReference that represents the order and the matching encrypted order data.
    /// </summary>
    [JsonPropertyName("order")]
    public required EncryptedOrderData4 Order { get; init; }
}
