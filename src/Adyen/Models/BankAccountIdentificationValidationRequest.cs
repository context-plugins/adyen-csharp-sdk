using System.Text.Json.Serialization;
using Adyen.Models.OneOf;

namespace Adyen.Models;

public record BankAccountIdentificationValidationRequest
{
    /// <summary>
    /// Bank account identification.
    /// </summary>
    [JsonPropertyName("accountIdentification")]
    public required AccountIdentification11 AccountIdentification { get; init; }
}
