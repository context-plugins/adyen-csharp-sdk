using Adyen.Models;

namespace Adyen.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the PatchStoresStoreId operation.
/// </summary>
public sealed record PatchStoresStoreIdRequest
{
    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }

    public UpdateStoreRequest? Body { get; init; }
}
