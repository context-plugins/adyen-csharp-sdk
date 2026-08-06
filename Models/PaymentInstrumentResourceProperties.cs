using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentInstrumentResourceProperties
{
    [JsonPropertyName("paymentInstrumentId")]
    [MinLength(1)]
    public required string PaymentInstrumentId { get; init; }
}
