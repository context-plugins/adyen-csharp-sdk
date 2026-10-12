namespace Adyen.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdSplitConfigurations operation.
/// </summary>
public sealed record GetMerchantsMerchantIdSplitConfigurationsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
