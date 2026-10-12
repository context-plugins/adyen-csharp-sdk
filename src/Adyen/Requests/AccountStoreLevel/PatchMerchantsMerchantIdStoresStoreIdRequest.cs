using Adyen.Models;

namespace Adyen.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the PatchMerchantsMerchantIdStoresStoreId operation.
/// </summary>
public sealed record PatchMerchantsMerchantIdStoresStoreIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }

    public UpdateStoreRequest? Body { get; init; }
}
