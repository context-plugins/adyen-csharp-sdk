using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The details of KYC Verification of the account holder.
/// </summary>
public record KycverificationResult1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolder")]
    public KyccheckResult? AccountHolder { get; init; }

    /// <summary>
    /// The results of the checks on the legal arrangements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangements")]
    public IReadOnlyList<KyclegalArrangementCheckResult>? LegalArrangements { get; init; }

    /// <summary>
    /// The results of the checks on the legal arrangement entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementsEntities")]
    public IReadOnlyList<KyclegalArrangementEntityCheckResult>? LegalArrangementsEntities { get; init; }

    /// <summary>
    /// The results of the checks on the payout methods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutMethods")]
    public IReadOnlyList<KycpayoutMethodCheckResult>? PayoutMethods { get; init; }

    /// <summary>
    /// The results of the checks on the shareholders.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholders")]
    public IReadOnlyList<KycshareholderCheckResult>? Shareholders { get; init; }

    /// <summary>
    /// The results of the checks on the signatories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatories")]
    public IReadOnlyList<KycsignatoryCheckResult>? Signatories { get; init; }

    /// <summary>
    /// The result of the check on the Ultimate Parent Company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ultimateParentCompany")]
    public IReadOnlyList<KycultimateParentCompanyCheckResult>? UltimateParentCompany { get; init; }
}
