using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record LegalEntityInfo
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("individual")]
    public Individual? Individual { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organization")]
    public Organization? Organization { get; init; }

    /// <summary>
    /// Your reference for the legal entity, maximum 150 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("soleProprietorship")]
    public SoleProprietorship? SoleProprietorship { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trust")]
    public Trust? Trust { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type182? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unincorporatedPartnership")]
    public UnincorporatedPartnership? UnincorporatedPartnership { get; init; }

    /// <summary>
    /// A key-value pair that specifies the verification process for a legal entity. Set to <b>upfront</b> for upfront verification for <see href="https://docs.adyen.com/marketplaces/verification-overview/verification-types/#upfront-verification">marketplaces</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationPlan")]
    public string? VerificationPlan { get; init; }
}
