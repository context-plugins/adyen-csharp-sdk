using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentMethodsResponse
{
    /// <summary>
    /// Detailed list of payment methods required to generate payment forms.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethods")]
    public IReadOnlyList<PaymentMethod>? PaymentMethods { get; init; }

    /// <summary>
    /// List of all stored payment methods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethods")]
    public IReadOnlyList<StoredPaymentMethod3>? StoredPaymentMethods { get; init; }
}
