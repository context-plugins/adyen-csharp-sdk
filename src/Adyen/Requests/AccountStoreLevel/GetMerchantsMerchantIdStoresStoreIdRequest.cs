namespace Adyen.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdStoresStoreId operation.
/// </summary>
public sealed record GetMerchantsMerchantIdStoresStoreIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }
}
