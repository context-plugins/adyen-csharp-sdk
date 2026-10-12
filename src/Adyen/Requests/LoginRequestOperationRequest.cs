using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the LoginRequest operation.
/// </summary>
public sealed record LoginRequestOperationRequest
{
    public LoginRequest? Body { get; init; }
}
