using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record PaymentsAppResponse
{
    /// <summary>
    /// List of Payments Apps.
    /// </summary>
    [JsonPropertyName("paymentsApps")]
    public required IReadOnlyList<PaymentsAppDto> PaymentsApps { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
