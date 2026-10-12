using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details about the ultimate parent company's business.
/// </summary>
public record UltimateParentCompanyBusinessDetails2
{
    /// <summary>
    /// The legal name of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalBusinessName")]
    public string? LegalBusinessName { get; init; }

    /// <summary>
    /// The registration number of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registrationNumber")]
    public string? RegistrationNumber { get; init; }

    /// <summary>
    /// Market Identifier Code (MIC).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stockExchange")]
    public string? StockExchange { get; init; }

    /// <summary>
    /// International Securities Identification Number (ISIN).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stockNumber")]
    public string? StockNumber { get; init; }

    /// <summary>
    /// Stock Ticker symbol.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stockTicker")]
    public string? StockTicker { get; init; }
}
