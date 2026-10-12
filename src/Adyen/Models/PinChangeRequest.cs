using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PinChangeRequest
{
    /// <summary>
    /// The symmetric session key that you encrypted with the <see href="https://docs.adyen.com/api-explorer/balanceplatform/2/get/publicKey">public key</see> that you received from Adyen.
    /// </summary>
    [JsonPropertyName("encryptedKey")]
    public required string EncryptedKey { get; init; }

    /// <summary>
    /// The encrypted <see href="https://www.pcisecuritystandards.org/glossary/pin-block">PIN block</see>.
    /// </summary>
    [JsonPropertyName("encryptedPinBlock")]
    public required string EncryptedPinBlock { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument, which is the card for which you are managing the PIN.
    /// </summary>
    [JsonPropertyName("paymentInstrumentId")]
    public required string PaymentInstrumentId { get; init; }

    /// <summary>
    /// The 16-digit token that you used to generate the <c>encryptedPinBlock</c>.
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; init; }
}
