using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TapToPay
{
    /// <summary>
    /// The text shown on the screen during the Tap to Pay transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDisplayName")]
    public string? MerchantDisplayName { get; init; }
}
