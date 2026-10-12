using Adyen.Models;

namespace Adyen.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the PostStores operation.
/// </summary>
public sealed record PostStoresRequest
{
    public StoreCreationWithMerchantCodeRequest? Body { get; init; }
}
