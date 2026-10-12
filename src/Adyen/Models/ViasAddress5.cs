using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The address of the entity.
/// </summary>
public record ViasAddress5
{
    /// <summary>
    /// The name of the city. Required if the <c>houseNumberOrName</c>, <c>street</c>, <c>postalCode</c>, or <c>stateOrProvince</c> are provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The two-character country code of the address in ISO-3166-1 alpha-2 format. For example, <b>NL</b>.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// The number or name of the house.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("houseNumberOrName")]
    public string? HouseNumberOrName { get; init; }

    /// <summary>
    /// The postal code. Required if the <c>houseNumberOrName</c>, <c>street</c>, <c>city</c>, or <c>stateOrProvince</c> are provided.
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
    /// The abbreviation of the state or province. Required if the <c>houseNumberOrName</c>, <c>street</c>, <c>city</c>, or <c>postalCode</c> are provided.
    /// <para>
    /// Maximum length:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>2 characters for addresses in the US or Canada.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>3 characters for all other countries.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stateOrProvince")]
    public string? StateOrProvince { get; init; }

    /// <summary>
    /// The name of the street. Required if the <c>houseNumberOrName</c>, <c>city</c>, <c>postalCode</c>, or <c>stateOrProvince</c> are provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("street")]
    public string? Street { get; init; }
}
