namespace Adyen.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId operation.
/// </summary>
public sealed record DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration.
    /// </summary>
    public required string SplitConfigurationId { get; init; }

    public required string RuleId { get; init; }
}
