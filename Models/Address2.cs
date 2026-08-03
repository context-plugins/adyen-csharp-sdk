using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The address of the account holder.
/// </summary>
public record Address2
{
    /// <summary>
    /// The name of the city. Maximum length: 3000 characters.
    /// </summary>
    [JsonPropertyName("city")]
    [MaxLength(3000)]
    public required string City { get; init; }

    /// <summary>
    /// The two-character ISO-3166-1 alpha-2 country code. For example, <b>US</b>.
    /// &gt; If you don't know the country or are not collecting the country from the shopper, provide <c>country</c> as <c>ZZ</c>.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// The number or name of the house. Maximum length: 3000 characters.
    /// </summary>
    [JsonPropertyName("houseNumberOrName")]
    [MaxLength(3000)]
    public required string HouseNumberOrName { get; init; }

    /// <summary>
    /// A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public required string PostalCode { get; init; }

    /// <summary>
    /// The two-character ISO 3166-2 state or province code. For example, <b>CA</b> in the US or <b>ON</b> in Canada.
    /// &gt; Required for the US and Canada.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stateOrProvince")]
    public string? StateOrProvince { get; init; }

    /// <summary>
    /// The name of the street. Maximum length: 3000 characters.
    /// &gt; The house number should not be included in this field; it should be separately provided via <c>houseNumberOrName</c>.
    /// </summary>
    [JsonPropertyName("street")]
    [MaxLength(3000)]
    public required string Street { get; init; }
}
