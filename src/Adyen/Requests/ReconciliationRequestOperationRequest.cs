using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the ReconciliationRequest operation.
/// </summary>
public sealed record ReconciliationRequestOperationRequest
{
    public ReconciliationRequest? Body { get; init; }
}
