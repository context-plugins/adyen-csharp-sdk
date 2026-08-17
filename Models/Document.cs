using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Document
{
    /// <summary>
    /// Object that contains the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachment")]
    public Attachment1? Attachment { get; init; }

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

    /// <summary>
    /// Contains information about the resource that owns the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("owner")]
    public OwnerEntity2? Owner { get; init; }

    /// <summary>
    /// Type of document, used when providing an ID number or uploading a document. The possible values depend on the legal entity type.
    /// <list type="bullet">
    ///   <item><description>For <b>organization</b>, the <c>type</c> values can be <b>proofOfAddress</b>, <b>registrationDocument</b>, <b>vatDocument</b>, <b>proofOfOrganizationTaxInfo</b>, <b>proofOfOwnership</b>, <b>proofOfIndustry</b>, <b>proofOfSignatory</b>, <b>proofOfDirector</b>, or <b>proofOfFundingOrWealthSource</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For <b>individual</b>, the <c>type</c> values can be <b>identityCard</b>, <b>driversLicense</b>, <b>passport</b>, <b>liveSelfie</b>, <b>proofOfNationalIdNumber</b>, <b>proofOfResidency</b>, <b>proofOfIndustry</b>, <b>proofOfIndividualTaxId</b>, <b>proofOfFundingOrWealthSource</b> or <b>proofOfRelationship</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For <b>soleProprietorship</b>, the <c>type</c> values can be <b>constitutionalDocument</b>, <b>proofOfAddress</b>, or <b>proofOfIndustry</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For <b>trust</b>, the <c>type</c> value is <b>constitutionalDocument</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For <b>unincorporatedPartnership</b>, the <c>type</c> value is <b>constitutionalDocument</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Use <b>bankStatement</b> to upload documents for a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see>.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type84 Type { get; init; }
}
