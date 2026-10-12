using System.Text.Json.Serialization;

namespace Adyen.Models;

public record FinancialReport
{
    /// <summary>
    /// The annual turnover of the business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annualTurnover")]
    public string? AnnualTurnover { get; init; }

    /// <summary>
    /// The balance sheet total of the business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceSheetTotal")]
    public string? BalanceSheetTotal { get; init; }

    /// <summary>
    /// The currency used for the annual turnover, balance sheet total, and net assets.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencyOfFinancialData")]
    public string? CurrencyOfFinancialData { get; init; }

    /// <summary>
    /// The date the financial data were provided, in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfFinancialData")]
    public string? DateOfFinancialData { get; init; }

    /// <summary>
    /// The number of employees of the business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employeeCount")]
    public string? EmployeeCount { get; init; }

    /// <summary>
    /// The net assets of the business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("netAssets")]
    public string? NetAssets { get; init; }
}
