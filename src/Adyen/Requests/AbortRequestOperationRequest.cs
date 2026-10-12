using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the AbortRequest operation.
/// </summary>
public sealed record AbortRequestOperationRequest
{
    public AbortRequest? Body { get; init; }
}
