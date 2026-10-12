using Adyen.Models;

namespace Adyen.Requests.SessionAuthentication;

/// <summary>
/// The inputs of the PostSessions2 operation.
/// </summary>
public sealed record PostSessions2Request
{
    public required AuthenticationSessionRequest Body { get; init; }
}
