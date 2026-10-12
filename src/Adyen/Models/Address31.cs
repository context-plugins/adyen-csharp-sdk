using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The address of the organization registered at their registrar (such as the Chamber of Commerce).
/// </summary>
public record Address31
{
    /// <summary>
    /// The name of the city. Required if <c>stateOrProvince</c> is provided.
    /// <para>
    /// If you specify the city, you must also send <c>postalCode</c> and <c>street</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The two-letter <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// The postal code. Required if <c>stateOrProvince</c> and/or <c>city</c> is provided.
    /// <para>
    /// When using alphanumeric postal codes, all letters must be uppercase. For example, 1234 AB or SW1A 1AA.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; init; }

    /// <summary>
    /// The two-letter ISO 3166-2 state or province code. For example, <b>CA</b> in the US. Required for Australia and New Zealand.
    /// <para>
    /// If you specify the state or province, you must also send <c>city</c>, <c>postalCode</c>, and <c>street</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stateOrProvince")]
    public string? StateOrProvince { get; init; }

    /// <summary>
    /// The name of the street, and the house or building number. Required if <c>stateOrProvince</c> and/or <c>city</c> is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("street")]
    public string? Street { get; init; }

    /// <summary>
    /// The apartment, unit, or suite number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("street2")]
    public string? Street2 { get; init; }
}
