using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataTemporaryServices
{
    /// <summary>
    /// The customer code, if supplied by a customer.
    /// * Encoding: ASCII
    /// * maxLength: 25
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.customerReference")]
    public string? EnhancedSchemeDataCustomerReference { get; init; }

    /// <summary>
    /// The name or ID of the person working in a temporary capacity.
    /// * maxLength: 40.
    /// * Must not be all spaces.
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.employeeName")]
    public string? EnhancedSchemeDataEmployeeName { get; init; }

    /// <summary>
    /// The job description of the person working in a temporary capacity.
    /// * maxLength: 40
    /// * Must not be all spaces.
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.jobDescription")]
    public string? EnhancedSchemeDataJobDescription { get; init; }

    /// <summary>
    /// The amount paid for regular hours worked, <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * maxLength: 7
    /// * Must not be empty
    /// * Can be all zeros
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.regularHoursRate")]
    public string? EnhancedSchemeDataRegularHoursRate { get; init; }

    /// <summary>
    /// The hours worked.
    /// * maxLength: 7
    /// * Must not be empty
    /// * Can be all zeros
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.regularHoursWorked")]
    public string? EnhancedSchemeDataRegularHoursWorked { get; init; }

    /// <summary>
    /// The name of the person requesting temporary services.
    /// * maxLength: 40
    /// * Must not be all zeros
    /// * Must not be all spaces
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.requestName")]
    public string? EnhancedSchemeDataRequestName { get; init; }

    /// <summary>
    /// The billing period start date.
    /// * Format: ddMMyy
    /// * maxLength: 6
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.tempStartDate")]
    public string? EnhancedSchemeDataTempStartDate { get; init; }

    /// <summary>
    /// The billing period end date.
    /// * Format: ddMMyy
    /// * maxLength: 6
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.tempWeekEnding")]
    public string? EnhancedSchemeDataTempWeekEnding { get; init; }

    /// <summary>
    /// The total tax amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>. For example, 2000 means USD 20.00
    /// * maxLength: 12
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.totalTaxAmount")]
    public string? EnhancedSchemeDataTotalTaxAmount { get; init; }
}
