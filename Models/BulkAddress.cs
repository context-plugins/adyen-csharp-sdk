using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BulkAddress
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
    [JsonPropertyName("company")]
    public string? Company { get; init; }

    /// <summary>
    /// The two-character ISO-3166-1 alpha-2 country code. For example, <b>US</b>.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// The email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The house number or name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("houseNumberOrName")]
    public string? HouseNumberOrName { get; init; }

    /// <summary>
    /// The name of the street and the number of the building.
    /// <para>
    /// For example: <b>Simon Carmiggeltstraat 6-50</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line1")]
    public string? Line1 { get; init; }

    /// <summary>
    /// Additional information about the delivery address. For example, an apartment number.
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
    /// The full telephone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobile")]
    public string? Mobile { get; init; }

    /// <summary>
    /// The recipient’s name (person or contact), for example ‘John Doe’.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The postal code.
    /// <para>
    /// Maximum length:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>5 digits for addresses in the US.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>10 characters for all other countries.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; init; }

    /// <summary>
    /// The two-letter ISO 3166-2 state or province code.
    /// <para>
    /// Maximum length: 2 characters for addresses in the US.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stateOrProvince")]
    public string? StateOrProvince { get; init; }

    /// <summary>
    /// The streetname of the house.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("street")]
    public string? Street { get; init; }
}
