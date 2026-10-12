using Adyen.Models;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostGetAuthenticationResult operation.
/// </summary>
public sealed record PostGetAuthenticationResultRequest
{
    public AuthenticationResultRequest? Body { get; init; }
}
