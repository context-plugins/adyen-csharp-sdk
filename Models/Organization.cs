using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Organization
{
    /// <summary>
    /// The two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code of the governing country.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryOfGoverningLaw")]
    public string? CountryOfGoverningLaw { get; init; }

    /// <summary>
    /// The date when the organization was incorporated in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfIncorporation")]
    public string? DateOfIncorporation { get; init; }

    /// <summary>
    /// Required if the value of <c>statusOfLegalProceeding</c> is one of the following:
    /// <para>
    /// <b>underJudicialAdministration</b>, <b>bankruptcyInsolvency</b>, <b>otherLegalMeasures</b>
    /// </para>
    /// <para>
    /// The date at which a legal proceeding was initiated, in <b>YYYY-MM-DD</b> format. Example: <b>2000-02-12</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfInitiationOfLegalProceeding")]
    public string? DateOfInitiationOfLegalProceeding { get; init; }

    /// <summary>
    /// Your description for the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The organization's trading name, if different from the registered legal name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("doingBusinessAs")]
    public string? DoingBusinessAs { get; init; }

    /// <summary>
    /// Set this to <b>true</b> if the organization or legal arrangement does not have a <c>Doing business as</c> name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("doingBusinessAsAbsent")]
    public bool? DoingBusinessAsAbsent { get; init; }

    /// <summary>
    /// The sector of the economy the legal entity operates within, represented by a 2-4 digit code that may include a ".". Example: 45.11
    /// <para>
    /// You can locate economic sector codes for your area by referencing codes defined by the NACE (Nomenclature of Economic Activities) used in the European Union.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("economicSector")]
    public string? EconomicSector { get; init; }

    /// <summary>
    /// The email address of the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The financial report information of the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("financialReports")]
    public IReadOnlyList<FinancialReport>? FinancialReports { get; init; }

    /// <summary>
    /// The global legal entity identifier for the organization.
    /// <para>
    /// This field is not required if the <c>registrationNumber</c> for the organization has been provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("globalLegalEntityIdentifier")]
    public string? GlobalLegalEntityIdentifier { get; init; }

    /// <summary>
    /// Indicates that the registered business address is also the company's headquarters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headOfficeIndicator")]
    public bool? HeadOfficeIndicator { get; init; }

    /// <summary>
    /// The institutional sector the organization operates within.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institutionalSector")]
    public InstitutionalSector? InstitutionalSector { get; init; }

    /// <summary>
    /// The type of business entity as defined in the national legal system. Use a legal form listed within the accepted legal forms compiled by the Central Bank of Europe.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalForm")]
    public string? LegalForm { get; init; }

    /// <summary>
    /// The organization's legal name.
    /// </summary>
    [JsonPropertyName("legalName")]
    public required string LegalName { get; init; }

    /// <summary>
    /// The phone number of the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public PhoneNumber2? Phone { get; init; }

    /// <summary>
    /// The address where the organization operates from. Provide this if the principal place of business is different from the <c>registeredAddress</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("principalPlaceOfBusiness")]
    public Address22? PrincipalPlaceOfBusiness { get; init; }

    /// <summary>
    /// The address of the organization registered at their registrar (such as the Chamber of Commerce).
    /// </summary>
    [JsonPropertyName("registeredAddress")]
    public required Address31 RegisteredAddress { get; init; }

    /// <summary>
    /// The organization's registration number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registrationNumber")]
    public string? RegistrationNumber { get; init; }

    /// <summary>
    /// Set this to <b>true</b> if the organization does not have a registration number available. Only applicable for organizations in New Zealand, and incorporated partnerships and government organizations in Australia.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registrationNumberAbsent")]
    public bool? RegistrationNumberAbsent { get; init; }

    /// <summary>
    /// The status of any current or past legal action taken against the legal entity.
    /// <para>
    /// Possible values: <b>noLegalActionsTaken</b>, <b>underJudicialAdministration</b>, <b>bankruptcyInsolvency</b>, <b>otherLegalMeasures</b>
    /// </para>
    /// <para>
    /// If the value of this field is <b>noLegalActionsTaken</b>, then <c>dateOfInitiationOfLegalProceeding</c> is not required. Otherwise, it is required.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusOfLegalProceeding")]
    public StatusOfLegalProceeding? StatusOfLegalProceeding { get; init; }

    /// <summary>
    /// Information about the organization's publicly traded stock. Provide this object only if <c>type</c> is <b>listedPublicCompany</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stockData")]
    public StockData2? StockData { get; init; }

    /// <summary>
    /// Support information for the legal entity. Required if you have a platform setup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("support")]
    public Support1? Support { get; init; }

    /// <summary>
    /// The tax information of the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxInformation")]
    public IReadOnlyList<TaxInformation>? TaxInformation { get; init; }

    /// <summary>
    /// The tax reporting classification (FATCA/CRS self-certification) of the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxReportingClassification")]
    public TaxReportingClassification2? TaxReportingClassification { get; init; }

    /// <summary>
    /// Type of organization.
    /// <para>
    /// Possible values: <b>associationIncorporated</b>, <b>governmentalOrganization</b>, <b>listedPublicCompany</b>, <b>nonProfit</b>, <b>partnershipIncorporated</b>, <b>privateCompany</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type161? Type { get; init; }

    /// <summary>
    /// The reason the organization has not provided a VAT number.
    /// <para>
    /// Possible values: <b>industryExemption</b>, <b>belowTaxThreshold</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vatAbsenceReason")]
    public VatAbsenceReason? VatAbsenceReason { get; init; }

    /// <summary>
    /// The organization's VAT number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vatNumber")]
    public string? VatNumber { get; init; }

    /// <summary>
    /// The website and app URL of the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webData")]
    public WebData1? WebData { get; init; }
}
