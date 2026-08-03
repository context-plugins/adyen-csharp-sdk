using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Document
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachment")]
    public Attachment? Attachment { get; init; }

    /// <summary>
    /// Array that contains the document. The array supports multiple attachments for uploading different sides or pages of a document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachments")]
    public IReadOnlyList<Attachment>? Attachments { get; init; }

    /// <summary>
    /// The creation date of the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creationDate")]
    public DateTimeOffset? CreationDate { get; init; }

    /// <summary>
    /// Your description for the document.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The expiry date of the document, in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryDate")]
    public string? ExpiryDate { get; init; }

    /// <summary>
    /// The filename of the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileName")]
    public string? FileName { get; init; }

    /// <summary>
    /// The unique identifier of the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code where the document was issued. For example, <b>US</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerCountry")]
    public string? IssuerCountry { get; init; }

    /// <summary>
    /// The state or province where the document was issued (AU only).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerState")]
    public string? IssuerState { get; init; }

    /// <summary>
    /// The modification date of the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modificationDate")]
    public DateTimeOffset? ModificationDate { get; init; }

    /// <summary>
    /// The number in the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("owner")]
    public OwnerEntity? Owner { get; init; }

    [JsonPropertyName("type")]
    public required Type81 Type { get; init; }
}
