using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Settings for <see href="https://docs.adyen.com/point-of-sale/pay-at-x">Pay-at-table</see> features.
/// </summary>
public record PayAtTable1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationMethod")]
    public AuthenticationMethod? AuthenticationMethod { get; init; }

    /// <summary>
    /// Enable Pay at table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablePayAtTable")]
    public bool? EnablePayAtTable { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrument")]
    public object? PaymentInstrument { get; init; }
}
