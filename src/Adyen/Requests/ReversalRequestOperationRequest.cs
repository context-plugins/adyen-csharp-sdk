using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the ReversalRequest operation.
/// </summary>
public sealed record ReversalRequestOperationRequest
{
    public ReversalRequest? Body { get; init; }
}
