using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Address6
{
    /// <summary>
    /// The name of the city.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The name of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; init; }

    /// <summary>
    /// The two-letter country code, in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; init; }

    /// <summary>
    /// The state or province as defined in <see href="https://www.iso.org/standard/72483.html">ISO 3166-2</see>. For example, <b>ON</b> for Ontario, Canada.
    /// <para>
    /// Applicable for the following countries:
    /// - Australia
    /// - Brazil
    /// - Canada
    /// - India
    /// - Mexico
    /// - New Zealand
    /// - United States
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stateOrProvince")]
    public string? StateOrProvince { get; init; }

    /// <summary>
    /// The name of the street, and the house or building number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; init; }

    /// <summary>
    /// Additional address details, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streetAddress2")]
    public string? StreetAddress2 { get; init; }
}
