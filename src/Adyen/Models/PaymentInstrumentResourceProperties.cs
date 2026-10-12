using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record PaymentInstrumentResourceProperties
{
    [JsonPropertyName("paymentInstrumentId")]
    [MinLength(1)]
    public required string PaymentInstrumentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
