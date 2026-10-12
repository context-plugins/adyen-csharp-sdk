using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BusinessDetails
{
    /// <summary>
    /// The registered name of the company (if it differs from the legal name of the company).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("doingBusinessAs")]
    public string? DoingBusinessAs { get; init; }

    /// <summary>
    /// The legal name of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalBusinessName")]
    public string? LegalBusinessName { get; init; }

    /// <summary>
    /// Information about the parent public company. Required if the account holder is 100% owned by a publicly listed company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("listedUltimateParentCompany")]
    public IReadOnlyList<UltimateParentCompany>? ListedUltimateParentCompany { get; init; }

    /// <summary>
    /// The registration number of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registrationNumber")]
    public string? RegistrationNumber { get; init; }

    /// <summary>
    /// Array containing information about individuals associated with the account holder either through ownership or control. For details about how you can identify them, refer to <see href="https://docs.adyen.com/classic-platforms/verification-process#identify-ubos">our verification guide</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholders")]
    public IReadOnlyList<ShareholderContact>? Shareholders { get; init; }

    /// <summary>
    /// Signatories associated with the company.
    /// Each array entry should represent one signatory.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatories")]
    public IReadOnlyList<SignatoryContact>? Signatories { get; init; }

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

    /// <summary>
    /// The tax ID of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxId")]
    public string? TaxId { get; init; }
}
