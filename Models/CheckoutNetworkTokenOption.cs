using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CheckoutNetworkTokenOption
{
    /// <summary>
    /// Set to <b>true</b> to enable forwarding network token cryptograms.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("includeCryptogram")]
    public bool? IncludeCryptogram { get; init; }

    /// <summary>
    /// Set to <b>true</b> to forward the network token for a card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useNetworkToken")]
    public bool? UseNetworkToken { get; init; }
}
