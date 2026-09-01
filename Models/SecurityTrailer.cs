using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// It contains information related to the security of the message.
/// SecurityTrailer as used by Adyen.
/// </summary>
public record SecurityTrailer
{
    [JsonPropertyName("AdyenCryptoVersion")]
    public required int AdyenCryptoVersion { get; init; }

    [JsonPropertyName("KeyIdentifier")]
    [RegularExpression("^.+$")]
    public required string KeyIdentifier { get; init; }

    [JsonPropertyName("KeyVersion")]
    public required int KeyVersion { get; init; }

    [JsonPropertyName("Nonce")]
    [RegularExpression("^.+$")]
    public required string Nonce { get; init; }

    [JsonPropertyName("Hmac")]
    [RegularExpression("^.+$")]
    public required string Hmac { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
