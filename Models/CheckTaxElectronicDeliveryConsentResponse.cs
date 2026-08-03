using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CheckTaxElectronicDeliveryConsentResponse
{
    /// <summary>
    /// Consent to electronically deliver tax form US1099-K.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("US1099k")]
    public bool? Us1099K { get; init; }
}
