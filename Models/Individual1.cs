using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Information about the individual. Required if <c>type</c> is <b>individual</b>.
/// </summary>
public record Individual1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("birthData")]
    public BirthData? BirthData { get; init; }

    /// <summary>
    /// The email address of the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identificationData")]
    public IdentificationData? IdentificationData { get; init; }

    [JsonPropertyName("name")]
    public required Name1 Name { get; init; }

    /// <summary>
    /// The individual's nationality.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    public string? Nationality { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; init; }

    [JsonPropertyName("residentialAddress")]
    public required Address1 ResidentialAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("support")]
    public Support? Support { get; init; }

    /// <summary>
    /// The tax information of the individual.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxInformation")]
    public IReadOnlyList<TaxInformation>? TaxInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webData")]
    public WebData? WebData { get; init; }
}
