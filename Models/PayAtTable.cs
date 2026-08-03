using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PayAtTable
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
