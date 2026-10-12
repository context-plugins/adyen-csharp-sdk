using Adyen.Models;

namespace Adyen.Requests.PaymentMethodsMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdPaymentMethodSettings operation.
/// </summary>
public sealed record PostMerchantsMerchantIdPaymentMethodSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public PaymentMethodSetupInfo? Body { get; init; }
}
