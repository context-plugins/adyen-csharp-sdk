using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information about the individual's identification document.
/// </summary>
public record IdentificationData1
{
    /// <summary>
    /// The card number of the document that was issued (AU only).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardNumber")]
    public string? CardNumber { get; init; }

    /// <summary>
    /// The expiry date of the document, in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryDate")]
    public string? ExpiryDate { get; init; }

    /// <summary>
    /// The two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code where the document was issued. For example, <b>US</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerCountry")]
    public string? IssuerCountry { get; init; }

    /// <summary>
    /// The state or province where the document was issued (AU only).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerState")]
    public string? IssuerState { get; init; }

    /// <summary>
    /// Applies only to individuals in the US. Set to <b>true</b> if the individual does not have an SSN. To verify their identity, Adyen will require them to upload an ID document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationalIdExempt")]
    public bool? NationalIdExempt { get; init; }

    /// <summary>
    /// The number in the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// Type of identity data. For individuals, the following types are supported. See our <see href="https://docs.adyen.com/platforms/onboard-users/onboarding-steps/?onboarding_type=custom">onboarding guide</see> for other supported countries.
    /// <list type="bullet">
    ///   <item><description>Australia: <b>driversLicense</b>, <b>passport</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Hong Kong: <b>driversLicense</b>, <b>nationalIdNumber</b>, <b>passport</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>New Zealand: <b>driversLicense</b>, <b>passport</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Singapore: <b>driversLicense</b>, <b>nationalIdNumber</b>, <b>passport</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>All other supported countries: <b>nationalIdNumber</b></description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type132 Type { get; init; }
}
