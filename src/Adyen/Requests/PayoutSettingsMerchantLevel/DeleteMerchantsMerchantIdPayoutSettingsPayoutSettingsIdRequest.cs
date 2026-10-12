namespace Adyen.Requests.PayoutSettingsMerchantLevel;

/// <summary>
/// The inputs of the DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId operation.
/// </summary>
public sealed record DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the payout setting.
    /// </summary>
    public required string PayoutSettingsId { get; init; }
}
