using Adyen.Models;

namespace Adyen.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId operation.
/// </summary>
public sealed record PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The identifier of the split configuration.
    /// </summary>
    public required string SplitConfigurationId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration rule.
    /// </summary>
    public required string RuleId { get; init; }

    public UpdateSplitConfigurationRuleRequest? Body { get; init; }
}
