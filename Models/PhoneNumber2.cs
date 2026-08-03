using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The phone number of the legal entity.
/// </summary>
public record PhoneNumber2
{
    /// <summary>
    /// The full phone number, including the country code. For example, <b>+3112345678</b>.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; init; }

    /// <summary>
    /// The two-letter <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code prefix of the phone number. For example, <b>US</b> or <b>NL</b>.
    /// <para>
    /// The value of the <c>phoneCountryCode</c> is determined by the country code digit(s) of <c>phone.number</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneCountryCode")]
    public string? PhoneCountryCode { get; init; }

    /// <summary>
    /// The type of phone number.
    ///  Possible values: <b>mobile</b>, <b>landline</b>, <b>sip</b>, <b>fax.</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
