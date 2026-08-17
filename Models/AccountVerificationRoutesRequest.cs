using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AccountVerificationRoutesRequest
{
    /// <summary>
    /// The location where the third-party individual's bank account is registered. Adyen uses this information to determine an available open banking provider, and to configure the open banking flow for that respective location.
    /// </summary>
    [JsonPropertyName("country")]
    public required AccountVerificationCountry2 Country { get; init; }

    /// <summary>
    /// The language to use in the open banking flow UI, specified by a combination of a two-letter <see href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">ISO 639-1</see> language code and an <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code.
    /// <para>
    /// This information is used to configure the open banking flow with the same language for a consistent user experience.
    /// </para>
    /// <para>
    /// Default value: <b>en-US</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// The URL where Adyen redirects the third-party individual after they complete the open banking flow.
    /// </summary>
    [JsonPropertyName("redirectUrl")]
    public required string RedirectUrl { get; init; }

    /// <summary>
    /// A value that helps you identify the request in callback handling. You can generate this value on a per-session basis to protect the callback against Cross-Site Request Forgery (CSRF) attacks. This value  must be composed of characters that can be successfully URL-encoded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }
}
