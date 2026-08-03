using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Address8
{
    /// <summary>
    /// The name of the city.
    /// <para>
    /// Supported characters: <b>[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \ |</b> and Space.
    /// </para>
    /// <para>
    /// &gt; Required when the <c>category</c> is <b>card</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    [MinLength(3)]
    public string? City { get; init; }

    /// <summary>
    /// The two-character ISO 3166-1 alpha-2 country code. For example, <b>US</b>, <b>NL</b>, or <b>GB</b>.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// The first line of the street address.
    /// <para>
    /// Supported characters: <b>[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \ |</b> and Space.
    /// </para>
    /// <para>
    /// &gt; Required when the <c>category</c> is <b>card</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line1")]
    public string? Line1 { get; init; }

    /// <summary>
    /// The second line of the street address.
    /// <para>
    /// Supported characters: <b>[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \ |</b> and Space.
    /// </para>
    /// <para>
    /// &gt; Required when the <c>category</c> is <b>card</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line2")]
    public string? Line2 { get; init; }

    /// <summary>
    /// The postal code.
    /// Maximum length:
    /// * 5 digits for an address in the US.
    /// * 10 characters for an address in all other countries.
    /// <para>
    /// Supported characters: <b>[a-z] [A-Z] [0-9]</b> and Space.
    /// </para>
    /// <para>
    /// &gt; Required for addresses in the US.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MinLength(3)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// The two-letter ISO 3166-2 state or province code. For example, <b>CA</b> in the US or <b>ON</b> in Canada.
    /// <para>
    ///    &gt; Required for the US and Canada.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stateOrProvince")]
    public string? StateOrProvince { get; init; }
}
