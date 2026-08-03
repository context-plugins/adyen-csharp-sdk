using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The tax reporting classification (FATCA/CRS self-certification) of the organization.
/// </summary>
public record TaxReportingClassification2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessType")]
    public BusinessType? BusinessType { get; init; }

    /// <summary>
    /// The Global Intermediary Identification Number (GIIN) required for FATCA. Only required if the organization is a US financial institution and the <c>businessType</c> is <b>financialInstitution</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("financialInstitutionNumber")]
    public string? FinancialInstitutionNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mainSourceOfIncome")]
    public MainSourceOfIncome? MainSourceOfIncome { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type151? Type { get; init; }
}
