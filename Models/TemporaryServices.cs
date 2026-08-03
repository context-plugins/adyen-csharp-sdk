using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TemporaryServices
{
    /// <summary>
    /// The name or ID of the person working in a temporary capacity.
    /// * Format: ASCII
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.employeeName</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employeeName")]
    public string? EmployeeName { get; init; }

    /// <summary>
    /// The billing period end date.
    /// * Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: yyyy-MM-dd
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.tempWeekEnding</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endDate")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The hourly rate for the temporary services, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.regularHoursRate</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hourRate")]
    public int? HourRate { get; init; }

    /// <summary>
    /// The number of hours worked during the billing period.
    /// * Format: Numeric
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.regularHoursWorked</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hoursWorked")]
    public int? HoursWorked { get; init; }

    /// <summary>
    /// The job description of the person working in a temporary capacity.
    /// * Format: ASCII
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.jobDescription</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jobDescription")]
    public string? JobDescription { get; init; }

    /// <summary>
    /// The name of the person requesting the temporary services.
    /// * Format: ASCII
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.requestName</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceRequestor")]
    public string? ServiceRequestor { get; init; }

    /// <summary>
    /// The billing period start date.
    /// * Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: yyyy-MM-dd
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.tempStartDate</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDate")]
    public DateTimeOffset? StartDate { get; init; }
}
