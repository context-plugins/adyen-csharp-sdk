using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostCloseStores operation.
/// </summary>
public sealed record PostCloseStoresRequest
{
    public CloseStoresRequest? Body { get; init; }
}
