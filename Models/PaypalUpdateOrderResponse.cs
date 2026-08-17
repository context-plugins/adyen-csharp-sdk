using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaypalUpdateOrderResponse
{
    /// <summary>
    /// The updated paymentData.
    /// </summary>
    [JsonPropertyName("paymentData")]
    public required string PaymentData { get; init; }

    /// <summary>
    /// The status of the request. This indicates whether the order was successfully updated with PayPal.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status4 Status { get; init; }
}
