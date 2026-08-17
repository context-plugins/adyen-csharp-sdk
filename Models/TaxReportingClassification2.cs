using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The tax reporting classification (FATCA/CRS self-certification) of the organization.
/// </summary>
public record TaxReportingClassification2
{
    /// <summary>
    /// The organization's business type.
    /// <para>
    /// Possible values: <b>other</b>, <b>listedPublicCompany</b>, <b>subsidiaryOfListedPublicCompany</b>, <b>governmentalOrganization</b>, <b>internationalOrganization</b>, <b>financialInstitution</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessType")]
    public BusinessType? BusinessType { get; init; }

    /// <summary>
    /// The Global Intermediary Identification Number (GIIN) required for FATCA. Only required if the organization is a US financial institution and the <c>businessType</c> is <b>financialInstitution</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("financialInstitutionNumber")]
    public string? FinancialInstitutionNumber { get; init; }

    /// <summary>
    /// The organization's main source of income. Only required if <c>businessType</c> is <b>other</b>.
    /// <para>
    /// Possible values: <b>businessOperation</b>, <b>realEstateSales</b>, <b>investmentInterestOrRoyalty</b>, <b>propertyRental</b>, <b>other</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mainSourceOfIncome")]
    public MainSourceOfIncome? MainSourceOfIncome { get; init; }

    /// <summary>
    /// The tax reporting classification type.
    /// <para>
    /// Possible values: <b>nonFinancialNonReportable</b>, <b>financialNonReportable</b>, <b>nonFinancialActive</b>, <b>nonFinancialPassive</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type151? Type { get; init; }
}
