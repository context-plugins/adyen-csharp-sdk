using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentInstrumentRevealResponse
{
    /// <summary>
    /// The data encrypted using the <c>encryptedKey</c>.
    /// </summary>
    [JsonPropertyName("encryptedData")]
    public required string EncryptedData { get; init; }
}
