using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the AdminRequest operation.
/// </summary>
public sealed record AdminRequestOperationRequest
{
    public AdminRequest? Body { get; init; }
}
