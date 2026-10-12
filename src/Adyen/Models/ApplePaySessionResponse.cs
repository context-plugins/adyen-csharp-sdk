using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ApplePaySessionResponse
{
    /// <summary>
    /// Base64 encoded data you need to <see href="https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation">complete the Apple Pay merchant validation</see>.
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; init; }
}
