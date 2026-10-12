using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Information about the individual. Required if <c>type</c> is <b>individual</b>.
/// </summary>
public record Individual1
{
    /// <summary>
    /// The individual's birth information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("birthData")]
    public BirthData1? BirthData { get; init; }

    /// <summary>
    /// The email address of the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// Information about the individual's identification document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identificationData")]
    public IdentificationData1? IdentificationData { get; init; }

    /// <summary>
    /// The individual's name.
    /// </summary>
    [JsonPropertyName("name")]
    public required Name23 Name { get; init; }

    /// <summary>
    /// The individual's nationality.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    public string? Nationality { get; init; }

    /// <summary>
    /// The phone number of the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public PhoneNumber2? Phone { get; init; }

    /// <summary>
    /// The residential address of the individual.
    /// </summary>
    [JsonPropertyName("residentialAddress")]
    public required Address13 ResidentialAddress { get; init; }

    /// <summary>
    /// Support information for the legal entity. Required if you have a platform setup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("support")]
    public Support1? Support { get; init; }

    /// <summary>
    /// The tax information of the individual.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxInformation")]
    public IReadOnlyList<TaxInformation>? TaxInformation { get; init; }

    /// <summary>
    /// The website and app URL of the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webData")]
    public WebData1? WebData { get; init; }
}
