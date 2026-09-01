using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record MandateUpdate
{
    /// <summary>
    /// The unique identifier of the payment instrument linked to the mandate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrumentId")]
    public string? PaymentInstrumentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
