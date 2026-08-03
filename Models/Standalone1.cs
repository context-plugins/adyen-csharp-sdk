using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for <see href="https://docs.adyen.com/point-of-sale/standalone/standalone-build/set-up-standalone#set-up-standalone-using-an-api-call">standalone</see> features.
/// </summary>
public record Standalone1
{
    /// <summary>
    /// The default currency of the standalone payment terminal as an <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</see> currency code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencyCode")]
    [StringLength(3, MinimumLength = 3)]
    public string? CurrencyCode { get; init; }

    /// <summary>
    /// Indicates whether the tipping options specified in <c>gratuities</c> are enabled on the standalone terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableGratuities")]
    public bool? EnableGratuities { get; init; }

    /// <summary>
    /// Enable standalone mode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableStandalone")]
    public bool? EnableStandalone { get; init; }
}
