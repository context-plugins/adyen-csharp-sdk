using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The details of KYC Verification of the account holder.
/// </summary>
public record KycVerificationResult1
{
    /// <summary>
    /// The results of the checks on the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolder")]
    public KycCheckResult2? AccountHolder { get; init; }

    /// <summary>
    /// The results of the checks on the legal arrangements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangements")]
    public IReadOnlyList<KycLegalArrangementCheckResult>? LegalArrangements { get; init; }

    /// <summary>
    /// The results of the checks on the legal arrangement entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementsEntities")]
    public IReadOnlyList<KycLegalArrangementEntityCheckResult>? LegalArrangementsEntities { get; init; }

    /// <summary>
    /// The results of the checks on the payout methods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutMethods")]
    public IReadOnlyList<KycPayoutMethodCheckResult>? PayoutMethods { get; init; }

    /// <summary>
    /// The results of the checks on the shareholders.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholders")]
    public IReadOnlyList<KycShareholderCheckResult>? Shareholders { get; init; }

    /// <summary>
    /// The results of the checks on the signatories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatories")]
    public IReadOnlyList<KycSignatoryCheckResult>? Signatories { get; init; }

    /// <summary>
    /// The result of the check on the Ultimate Parent Company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ultimateParentCompany")]
    public IReadOnlyList<KycUltimateParentCompanyCheckResult>? UltimateParentCompany { get; init; }
}
