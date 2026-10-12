namespace Adyen.Requests.PaymentMethodsMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdPaymentMethodSettings operation.
/// </summary>
public sealed record GetMerchantsMerchantIdPaymentMethodSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the store for which to return the payment methods.
    /// </summary>
    public string? StoreId { get; init; }

    /// <summary>
    /// The unique identifier of the Business Line for which to return the payment methods.
    /// </summary>
    public string? BusinessLineId { get; init; }

    /// <summary>
    /// The number of items to have on a page, maximum 100. The default is 10 items on a page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    public int? PageNumber { get; init; }
}
