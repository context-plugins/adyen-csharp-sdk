using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentsAppResponse
{
    /// <summary>
    /// List of Payments Apps.
    /// </summary>
    [JsonPropertyName("paymentsApps")]
    public required IReadOnlyList<PaymentsAppDto> PaymentsApps { get; init; }
}
