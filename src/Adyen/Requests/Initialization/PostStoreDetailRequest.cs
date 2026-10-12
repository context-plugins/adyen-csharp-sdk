using Adyen.Models;

namespace Adyen.Requests.Initialization;

/// <summary>
/// The inputs of the PostStoreDetail operation.
/// </summary>
public sealed record PostStoreDetailRequest
{
    public StoreDetailRequest? Body { get; init; }
}
