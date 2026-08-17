using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record LegalEntityAssociation
{
    /// <summary>
    /// The unique identifier of another legal entity with which the <c>legalEntityId</c> is associated. When the <c>legalEntityId</c> is associated to legal entities other than the current one, the response returns all the associations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("associatorId")]
    public string? AssociatorId { get; init; }

    /// <summary>
    /// The legal entity type of associated legal entity.
    /// <para>
    /// For example, <b>organization</b>, <b>soleProprietorship</b> or <b>individual</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityType")]
    public string? EntityType { get; init; }

    /// <summary>
    /// The individual's job title if the <c>type</c> is <b>uboThroughControl</b> or <b>signatory</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jobTitle")]
    public string? JobTitle { get; init; }

    /// <summary>
    /// The unique identifier of the associated <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id">legal entity</see>.
    /// </summary>
    [JsonPropertyName("legalEntityId")]
    public required string LegalEntityId { get; init; }

    /// <summary>
    /// The name of the associated <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id">legal entity</see>.
    /// <list type="bullet">
    ///   <item><description>For <b>individual</b>, <c>name.firstName</c> and <c>name.lastName</c>.</description></item>
    ///   <item><description>For <b>organization</b>, <c>legalName</c>.</description></item>
    ///   <item><description>For <b>soleProprietorship</b>, <c>name</c>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Default value: <b>false</b>
    /// Set to <b>true</b> if the entity association <c>type</c> <b>director</b>, <b>secondaryPartner</b> or <b>shareholder</b> is also a nominee. Only applicable to New Zealand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nominee")]
    public bool? Nominee { get; init; }

    /// <summary>
    /// The individual's relationship to a legal representative if the <c>type</c> is <b>legalRepresentative</b>. Possible values: <b>parent</b>, <b>guardian</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("relationship")]
    public string? Relationship { get; init; }

    /// <summary>
    /// Defines the KYC exemption reason for a settlor associated with a trust. Only applicable to trusts in Australia.
    /// <para>
    /// For example, <b>professionalServiceProvider</b>, <b>deceased</b>, or <b>contributionBelowThreshold</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlorExemptionReason")]
    public IReadOnlyList<string>? SettlorExemptionReason { get; init; }

    /// <summary>
    /// Defines the relationship of the legal entity to the current legal entity.
    /// <para>
    /// Possible value for individuals: <b>legalRepresentative</b>.
    /// </para>
    /// <para>
    /// Possible values for organizations: <b>director</b>, <b>signatory</b>, <b>trustOwnership</b>, <b>uboThroughOwnership</b>, <b>uboThroughControl</b>, <b>ultimateParentCompany</b>, or <b>immediateParentCompany</b>.
    /// </para>
    /// <para>
    /// Possible values for sole proprietorships: <b>soleProprietorship</b>.
    /// </para>
    /// <para>
    /// Possible value for trusts: <b>trust</b>.
    /// </para>
    /// <para>
    /// Possible values for trust members: <b>definedBeneficiary</b>, <b>protector</b>, <b>secondaryTrustee</b>, <b>settlor</b>, <b>uboThroughControl</b>, or <b>uboThroughOwnership</b>.
    /// </para>
    /// <para>
    /// Possible value for unincorporated partnership: <b>unincorporatedPartnership</b>.
    /// </para>
    /// <para>
    /// Possible values for unincorporated partnership members: <b>secondaryPartner</b>, <b>uboThroughControl</b>, <b>uboThroughOwnership</b>
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type142 Type { get; init; }
}
