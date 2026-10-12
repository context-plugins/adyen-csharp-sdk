using Adyen.Models;

namespace Adyen.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdSplitConfigurations operation.
/// </summary>
public sealed record PostMerchantsMerchantIdSplitConfigurationsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public SplitConfiguration? Body { get; init; }
}
