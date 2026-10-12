namespace Adyen.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the GetStoresStoreId operation.
/// </summary>
public sealed record GetStoresStoreIdRequest
{
    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }
}
