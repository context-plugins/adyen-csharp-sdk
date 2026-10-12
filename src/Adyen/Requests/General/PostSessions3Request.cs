using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostSessions3 operation.
/// </summary>
public sealed record PostSessions3Request
{
    public CreateSessionRequest? Body { get; init; }
}
