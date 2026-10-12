using Adyen.Models;

namespace Adyen.Requests.PayoutSettingsMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdPayoutSettings operation.
/// </summary>
public sealed record PostMerchantsMerchantIdPayoutSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public PayoutSettingsRequest? Body { get; init; }
}
