namespace Adyen.Requests.PaymentMethodsMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId operation.
/// </summary>
public sealed record GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the payment method.
    /// </summary>
    public required string PaymentMethodId { get; init; }
}
