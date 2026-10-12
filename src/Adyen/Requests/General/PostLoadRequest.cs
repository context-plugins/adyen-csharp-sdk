using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostLoad operation.
/// </summary>
public sealed record PostLoadRequest
{
    public StoredValueLoadRequest? Body { get; init; }
}
