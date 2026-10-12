using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the LogoutRequest operation.
/// </summary>
public sealed record LogoutRequestOperationRequest
{
    public LogoutRequest? Body { get; init; }
}
