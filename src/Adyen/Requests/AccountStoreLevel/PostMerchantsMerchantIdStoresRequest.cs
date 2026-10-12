using Adyen.Models;

namespace Adyen.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdStores operation.
/// </summary>
public sealed record PostMerchantsMerchantIdStoresRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public StoreCreationRequest? Body { get; init; }
}
