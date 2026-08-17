using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PersonalDocumentData
{
    /// <summary>
    /// The expiry date of the document,
    ///  in ISO-8601 YYYY-MM-DD format. For example, <b>2000-01-31</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; init; }

    /// <summary>
    /// The country where the document was issued, in the two-character
    /// <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> format. For example, <b>NL</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerCountry")]
    [StringLength(2, MinimumLength = 2)]
    public string? IssuerCountry { get; init; }

    /// <summary>
    /// The state where the document was issued (if applicable).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerState")]
    public string? IssuerState { get; init; }

    /// <summary>
    /// The number in the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// The type of the document. Possible values: <b>ID</b>, <b>DRIVINGLICENSE</b>, <b>PASSPORT</b>, <b>SOCIALSECURITY</b>, <b>VISA</b>.
    /// <para>
    /// To delete an existing entry for a document <c>type</c>, send only the <c>type</c> field in your request.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type15 Type { get; init; }
}
