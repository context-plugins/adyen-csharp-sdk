using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BrowserInfo2
{
    /// <summary>
    /// The accept header value of the shopper's browser.
    /// </summary>
    [JsonPropertyName("acceptHeader")]
    public required string AcceptHeader { get; init; }

    /// <summary>
    /// The color depth of the shopper's browser in bits per pixel. This should be obtained by using the browser's <c>screen.colorDepth</c> property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth.
    /// </summary>
    [JsonPropertyName("colorDepth")]
    public required int ColorDepth { get; init; }

    /// <summary>
    /// Boolean value indicating if the shopper's browser is able to execute Java.
    /// </summary>
    [JsonPropertyName("javaEnabled")]
    public required bool JavaEnabled { get; init; }

    /// <summary>
    /// Boolean value indicating if the shopper's browser is able to execute JavaScript. A default 'true' value is assumed if the field is not present.
    /// </summary>
    [JsonPropertyName("javaScriptEnabled")]
    public bool? JavaScriptEnabled { get; init; } = true;

    /// <summary>
    /// The <c>navigator.language</c> value of the shopper's browser (as defined in IETF BCP 47).
    /// </summary>
    [JsonPropertyName("language")]
    public required string Language { get; init; }

    /// <summary>
    /// The total height of the shopper's device screen in pixels.
    /// </summary>
    [JsonPropertyName("screenHeight")]
    public required int ScreenHeight { get; init; }

    /// <summary>
    /// The total width of the shopper's device screen in pixels.
    /// </summary>
    [JsonPropertyName("screenWidth")]
    public required int ScreenWidth { get; init; }

    /// <summary>
    /// Time difference between UTC time and the shopper's browser local time, in minutes.
    /// </summary>
    [JsonPropertyName("timeZoneOffset")]
    public required int TimeZoneOffset { get; init; }

    /// <summary>
    /// The user agent value of the shopper's browser.
    /// </summary>
    [JsonPropertyName("userAgent")]
    public required string UserAgent { get; init; }
}
