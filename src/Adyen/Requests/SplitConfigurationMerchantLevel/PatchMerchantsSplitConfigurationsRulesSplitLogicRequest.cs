using Adyen.Models;

namespace Adyen.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the PatchMerchantsSplitConfigurationsRulesSplitLogic operation.
/// </summary>
public sealed record PatchMerchantsSplitConfigurationsRulesSplitLogicRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration.
    /// </summary>
    public required string SplitConfigurationId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration rule.
    /// </summary>
    public required string RuleId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration split.
    /// </summary>
    public required string SplitLogicId { get; init; }

    public UpdateSplitConfigurationLogicRequest? Body { get; init; }
}
