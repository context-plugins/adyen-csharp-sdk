using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetOnboardingUrlRequest
{
    /// <summary>
    /// The account holder code you provided when you created the account holder.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collectInformation")]
    public CollectInformation? CollectInformation { get; init; }

    /// <summary>
    /// Indicates if editing checks is allowed even if all the checks have passed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("editMode")]
    public bool? EditMode { get; init; }

    /// <summary>
    /// The URL to which the account holder is redirected after completing an OAuth authentication with a bank through Trustly/PayMyBank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobileOAuthCallbackUrl")]
    public string? MobileOauthCallbackUrl { get; init; }

    /// <summary>
    /// The platform name which will show up in the welcome page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformName")]
    public string? PlatformName { get; init; }

    /// <summary>
    /// The URL where the account holder will be redirected back to after they complete the onboarding, or if their session times out. Maximum length of 500 characters. If you don't provide this, the account holder will be redirected back to the default return URL configured in your platform account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnUrl")]
    public string? ReturnUrl { get; init; }

    /// <summary>
    /// The language to be used in the page, specified by a combination of a language and country code. For example, <b>pt-BR</b>.
    /// <para>
    /// If not specified in the request or if the language is not supported, the page uses the browser language. If the browser language is not supported, the page uses <b>en-US</b> by default.
    /// </para>
    /// <para>
    /// For a list of supported languages, refer to <see href="https://docs.adyen.com/classic-platforms/hosted-onboarding-page/customize-experience#change-page-language">Change the page language</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperLocale")]
    public string? ShopperLocale { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showPages")]
    public ShowPages? ShowPages { get; init; }
}
