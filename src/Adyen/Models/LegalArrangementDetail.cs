using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record LegalArrangementDetail
{
    /// <summary>
    /// The address of the legal arrangement.
    /// </summary>
    [JsonPropertyName("address")]
    public required ViasAddress4 Address { get; init; }

    /// <summary>
    /// Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create a legal arrangement.
    /// Use only when updating an account holder. If you include this field when creating an account holder, the request will fail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementCode")]
    public string? LegalArrangementCode { get; init; }

    /// <summary>
    /// An array containing information about other entities that are part of the legal arrangement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementEntities")]
    public IReadOnlyList<LegalArrangementEntityDetail>? LegalArrangementEntities { get; init; }

    /// <summary>
    /// Your reference for the legal arrangement. Must be between 3 to 128 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementReference")]
    public string? LegalArrangementReference { get; init; }

    /// <summary>
    /// The form of legal arrangement. Required if <c>type</c> is <b>Trust</b> or <b>Partnership</b>.
    /// <para>
    /// The possible values depend on the <c>type</c>.
    /// </para>
    /// <list type="bullet">
    ///   <item><description>For <c>type</c> <b>Trust</b>:  <b>CashManagementTrust</b>, <b>CorporateUnitTrust</b>, <b>DeceasedEstate</b>, <b>DiscretionaryInvestmentTrust</b>, <b>DiscretionaryServicesManagementTrust</b>, <b>DiscretionaryTradingTrust</b>, <b>FirstHomeSaverAccountsTrust</b>, <b>FixedTrust</b>, <b>FixedUnitTrust</b>, <b>HybridTrust</b>, <b>ListedPublicUnitTrust</b>, <b>OtherTrust</b>, <b>PooledSuperannuationTrust</b>, <b>PublicTradingTrust</b>, or <b>UnlistedPublicUnitTrust</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For <c>type</c> <b>Partnership</b>: <b>LimitedPartnership</b>, <b>FamilyPartnership</b>, or <b>OtherPartnership</b></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalForm")]
    public LegalForm? LegalForm { get; init; }

    /// <summary>
    /// The legal name of the legal arrangement. Minimum length: 3 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The registration number of the legal arrangement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registrationNumber")]
    public string? RegistrationNumber { get; init; }

    /// <summary>
    /// The tax identification number of the legal arrangement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxNumber")]
    public string? TaxNumber { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/classic-platforms/verification-process/legal-arrangements#types-of-legal-arrangements">type of legal arrangement</see>.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>Association</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Partnership</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>SoleProprietorship</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Trust</b></description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type110 Type { get; init; }
}
