using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentInstrumentRevealRequest
{
    /// <summary>
    /// The symmetric session key that you encrypted with the <see href="https://docs.adyen.com/api-explorer/balanceplatform/2/get/publicKey">public key</see> that you received from Adyen.
    /// </summary>
    [JsonPropertyName("encryptedKey")]
    public required string EncryptedKey { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument, which is the card for which you are managing the PIN.
    /// </summary>
    [JsonPropertyName("paymentInstrumentId")]
    public required string PaymentInstrumentId { get; init; }
}
