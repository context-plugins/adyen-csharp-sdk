using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The address of the store. It is not possible to update the country of the store.
/// </summary>
public record UpdatableAddress1
{
    /// <summary>
    /// The name of the city.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The street address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line1")]
    public string? Line1 { get; init; }

    /// <summary>
    /// Second address line.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line2")]
    public string? Line2 { get; init; }

    /// <summary>
    /// Third address line.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line3")]
    public string? Line3 { get; init; }

    /// <summary>
    /// The postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; init; }

    /// <summary>
    /// The state or province code as defined in <see href="https://www.iso.org/standard/72483.html">ISO 3166-2</see>. For example, <b>ON</b> for Ontario, Canada.
    /// <para>
    /// Required for the following countries:
    ///  - Australia
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
}
