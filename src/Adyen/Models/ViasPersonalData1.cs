using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the person.
/// </summary>
public record ViasPersonalData1
{
    /// <summary>
    /// The person's date of birth, in ISO-8601 YYYY-MM-DD format. For example, <b>2000-01-31</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    public string? DateOfBirth { get; init; }

    /// <summary>
    /// Array that contains information about the person's identification document. You can submit only one entry per document type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentData")]
    public IReadOnlyList<PersonalDocumentData>? DocumentData { get; init; }

    /// <summary>
    /// The nationality of the person represented by a two-character country code,  in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> format. For example, <b>NL</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    [StringLength(2, MinimumLength = 2)]
    public string? Nationality { get; init; }
}
