using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record LegalEntity3
{
    /// <summary>
    /// Contains key-value pairs that specify the actions that the legal entity can do in your platform.The key is a capability required for your integration. For example, <b>issueCard</b> for Issuing. The value is an object containing the settings for the capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public IReadOnlyDictionary<string, LegalEntityCapability>? Capabilities { get; init; }

    /// <summary>
    /// List of documents uploaded for the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentDetails")]
    public IReadOnlyList<DocumentReference>? DocumentDetails { get; init; }

    /// <summary>
    /// List of documents uploaded for the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documents")]
    public IReadOnlyList<EntityReference>? Documents { get; init; }

    /// <summary>
    /// List of legal entities associated with the current legal entity.
    /// For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityAssociations")]
    public IReadOnlyList<LegalEntityAssociation>? EntityAssociations { get; init; }

    /// <summary>
    /// The unique identifier of the legal entity.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("individual")]
    public Individual? Individual { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organization")]
    public Organization? Organization { get; init; }

    /// <summary>
    /// List of verification errors related to capabilities for the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("problems")]
    public IReadOnlyList<CapabilityProblem1>? Problems { get; init; }

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

    /// <summary>
    /// List of transfer instruments that the legal entity owns.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstruments")]
    public IReadOnlyList<TransferInstrumentReference>? TransferInstruments { get; init; }

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
    /// List of verification deadlines and the capabilities that will be disallowed if verification errors are not resolved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationDeadlines")]
    public IReadOnlyList<VerificationDeadline>? VerificationDeadlines { get; init; }

    /// <summary>
    /// A key-value pair that specifies the verification process for a legal entity. Set to <b>upfront</b> for upfront verification for <see href="https://docs.adyen.com/marketplaces/verification-overview/verification-types/#upfront-verification">marketplaces</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationPlan")]
    public string? VerificationPlan { get; init; }
}
