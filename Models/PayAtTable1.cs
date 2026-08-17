using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Settings for <see href="https://docs.adyen.com/point-of-sale/pay-at-x">Pay-at-table</see> features.
/// </summary>
public record PayAtTable1
{
    /// <summary>
    /// Allowed authentication methods: Magswipe, Manual Entry.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationMethod")]
    public AuthenticationMethod? AuthenticationMethod { get; init; }

    /// <summary>
    /// Enable Pay at table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablePayAtTable")]
    public bool? EnablePayAtTable { get; init; }

    /// <summary>
    /// Sets the allowed payment instrument for Pay at table transactions.  Can be: <b>cash</b> or <b>card</b>. If not set, the terminal presents both options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrument")]
    public PaymentInstrument? PaymentInstrument { get; init; }
}
