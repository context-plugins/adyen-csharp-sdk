using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The phone number of the account holder.
/// &gt; Required if a <c>fullPhoneNumber</c> is not provided.
/// </summary>
public record ViasPhoneNumber3
{
    /// <summary>
    /// The two-character country code of the phone number.
    /// &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. 'NL').
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneCountryCode")]
    public string? PhoneCountryCode { get; init; }

    /// <summary>
    /// The phone number.
    /// &gt;The inclusion of the phone number country code is not necessary.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The type of the phone number.
    /// &gt;The following values are permitted: <c>Landline</c>, <c>Mobile</c>, <c>SIP</c>, <c>Fax</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneType")]
    public PhoneType? PhoneType { get; init; }
}
