using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BankAccountIdentificationValidationRequest
{
    /// <summary>
    /// Bank account identification.
    /// </summary>
    [JsonPropertyName("accountIdentification")]
    public required AccountIdentification1 AccountIdentification { get; init; }
}
