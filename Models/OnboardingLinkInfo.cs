using System.Text.Json.Serialization;

namespace Adyen.Models;

public record OnboardingLinkInfo
{
    /// <summary>
    /// The language that will be used for the page, specified by a combination of two letter <see href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639-1</see> language and <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country codes. See possible valuesfor <see href="https://docs.adyen.com/marketplaces/onboard-users/hosted#supported-languages">marketplaces</see> or <see href="https://docs.adyen.com/platforms/onboard-users/hosted#supported-languages">platforms</see>.
    /// <para>
    /// If not specified in the request or if the language is not supported, the page uses the browser language. If the browser language is not supported, the page uses <b>en-US</b> by default.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// The URL where the user is redirected after they complete hosted onboarding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; init; }

    /// <summary>
    /// Key-value pairs indicating the settings for the hosted onboarding page. The key represents a specific setting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    public OnboardingLinkSettings2? Settings { get; init; }

    /// <summary>
    /// The unique identifier of the hosted onboarding theme.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("themeId")]
    public string? ThemeId { get; init; }
}
