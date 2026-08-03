using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains indicators whether specific pages must be shown to the account holder.
/// </summary>
public record ShowPages2
{
    /// <summary>
    /// Indicates whether the page with bank account details must be shown. Defaults to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankDetailsSummaryPage")]
    public bool? BankDetailsSummaryPage { get; init; }

    /// <summary>
    /// Indicates whether the bank check instant verification' details must be shown. Defaults to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankVerificationPage")]
    public bool? BankVerificationPage { get; init; }

    /// <summary>
    /// Indicates whether the page with the company's or organization's details must be shown. Defaults to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessDetailsSummaryPage")]
    public bool? BusinessDetailsSummaryPage { get; init; }

    /// <summary>
    /// Indicates whether the checks overview page must be shown. Defaults to <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checksOverviewPage")]
    public bool? ChecksOverviewPage { get; init; }

    /// <summary>
    /// Indicates whether the page with the individual's details must be shown. Defaults to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("individualDetailsSummaryPage")]
    public bool? IndividualDetailsSummaryPage { get; init; }

    /// <summary>
    /// Indicates whether the page with the legal arrangements' details must be shown. Defaults to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementsDetailsSummaryPage")]
    public bool? LegalArrangementsDetailsSummaryPage { get; init; }

    /// <summary>
    /// Indicates whether the page to manually add bank account' details must be shown. Defaults to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("manualBankAccountPage")]
    public bool? ManualBankAccountPage { get; init; }

    /// <summary>
    /// Indicates whether the page with the shareholders' details must be shown. Defaults to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderDetailsSummaryPage")]
    public bool? ShareholderDetailsSummaryPage { get; init; }

    /// <summary>
    /// Indicates whether the welcome page must be shown. Defaults to <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("welcomePage")]
    public bool? WelcomePage { get; init; }
}
