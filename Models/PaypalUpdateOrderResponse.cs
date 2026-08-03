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

    [JsonPropertyName("status")]
    public required Status42 Status { get; init; }
}
