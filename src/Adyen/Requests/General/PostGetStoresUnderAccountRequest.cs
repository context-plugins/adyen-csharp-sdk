using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostGetStoresUnderAccount operation.
/// </summary>
public sealed record PostGetStoresUnderAccountRequest
{
    public GetStoresUnderAccountRequest? Body { get; init; }
}
