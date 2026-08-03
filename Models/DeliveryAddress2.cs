using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The address of the contact.
/// </summary>
public record DeliveryAddress2
{
    /// <summary>
    /// The name of the city.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The two-character ISO-3166-1 alpha-2 country code. For example, <b>US</b>.
    /// &gt;If you don't know the country or are not collecting the country from the shopper, provide <c>country</c> as <c>ZZ</c>.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// The name of the street. Do not include the number of the building.
    /// <para>
    /// For example, if the address is Simon Carmiggeltstraat 6-50, provide <b>Simon Carmiggeltstraat</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line1")]
    public string? Line1 { get; init; }

    /// <summary>
    /// The number of the building.
    /// <para>
    /// For example, if the address is Simon Carmiggeltstraat 6-50, provide <b>6-50</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line2")]
    public string? Line2 { get; init; }

    /// <summary>
    /// Additional information about the delivery address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line3")]
    public string? Line3 { get; init; }

    /// <summary>
    /// The postal code.
    /// Maximum length:
    /// * 5 digits for an address in the US.
    /// * 10 characters for an address in all other countries.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; init; }

    /// <summary>
    /// The state or province code, maximum 3 characters. For example, <b>CA</b> for California in the US or <b>ON</b> for Ontario in Canada.
    /// &gt; Required for the US and Canada.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stateOrProvince")]
    public string? StateOrProvince { get; init; }
}
