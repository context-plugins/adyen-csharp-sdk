using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record LegalEntityInfoRequiredType
{
    /// <summary>
    /// Contains key-value pairs that specify the actions that the legal entity can do in your platform.The key is a capability required for your integration. For example, <b>issueCard</b> for Issuing. The value is an object containing the settings for the capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public IReadOnlyDictionary<string, LegalEntityCapability>? Capabilities { get; init; }

    /// <summary>
    /// List of legal entities associated with the current legal entity.
    /// For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityAssociations")]
    public IReadOnlyList<LegalEntityAssociation>? EntityAssociations { get; init; }

    /// <summary>
    /// Information about the individual. Required if <c>type</c> is <b>individual</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("individual")]
    public Individual1? Individual { get; init; }

    /// <summary>
    /// Information about the organization. Required if <c>type</c> is <b>organization</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organization")]
    public Organization1? Organization { get; init; }

    /// <summary>
    /// Your reference for the legal entity, maximum 150 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    /// <summary>
    /// Information about the sole proprietorship. Required if <c>type</c> is <b>soleProprietorship</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("soleProprietorship")]
    public SoleProprietorship1? SoleProprietorship { get; init; }

    /// <summary>
    /// Information about the trust. Required if <c>type</c> is <b>trust</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trust")]
    public Trust1? Trust { get; init; }

    /// <summary>
    /// The type of legal entity.
    /// <para>
    ///  Possible values: <b>individual</b>, <b>organization</b>, <b>soleProprietorship</b>, or <b>trust</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type213 Type { get; init; }

    /// <summary>
    /// Information about the unincorporated partnership. Required if <c>type</c> is <b>unincorporatedPartnership</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unincorporatedPartnership")]
    public UnincorporatedPartnership1? UnincorporatedPartnership { get; init; }

    /// <summary>
    /// A key-value pair that specifies the verification process for a legal entity. Set to <b>upfront</b> for upfront verification for <see href="https://docs.adyen.com/marketplaces/verification-overview/verification-types/#upfront-verification">marketplaces</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationPlan")]
    public string? VerificationPlan { get; init; }
}
