using Adyen.Models;

namespace Adyen.Requests.Initialization;

/// <summary>
/// The inputs of the PostStoreDetailAndSubmitThirdParty operation.
/// </summary>
public sealed record PostStoreDetailAndSubmitThirdPartyRequest
{
    public StoreDetailAndSubmitRequest? Body { get; init; }
}
