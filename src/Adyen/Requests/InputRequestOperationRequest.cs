using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the InputRequest operation.
/// </summary>
public sealed record InputRequestOperationRequest
{
    public InputRequest? Body { get; init; }
}
