using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for Tap to Pay.
/// </summary>
public record TapToPay1
{
    /// <summary>
    /// The text shown on the screen during the Tap to Pay transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDisplayName")]
    public string? MerchantDisplayName { get; init; }
}
