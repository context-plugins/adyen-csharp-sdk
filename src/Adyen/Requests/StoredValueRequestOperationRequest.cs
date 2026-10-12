using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the StoredValueRequest operation.
/// </summary>
public sealed record StoredValueRequestOperationRequest
{
    public StoredValueRequest? Body { get; init; }
}
