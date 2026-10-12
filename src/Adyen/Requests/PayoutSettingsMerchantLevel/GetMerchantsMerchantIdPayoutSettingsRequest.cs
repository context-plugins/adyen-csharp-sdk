namespace Adyen.Requests.PayoutSettingsMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdPayoutSettings operation.
/// </summary>
public sealed record GetMerchantsMerchantIdPayoutSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
