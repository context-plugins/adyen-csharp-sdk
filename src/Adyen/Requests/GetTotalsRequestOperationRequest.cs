using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the GetTotalsRequest operation.
/// </summary>
public sealed record GetTotalsRequestOperationRequest
{
    public GetTotalsRequest? Body { get; init; }
}
