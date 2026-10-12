using Adyen.Models;

namespace Adyen.Requests.IDealProfiles;

/// <summary>
/// The inputs of the PostIdealProfileAuthenticate operation.
/// </summary>
public sealed record PostIdealProfileAuthenticateRequest
{
    public required IdealAuthenticateRequest Body { get; init; }
}
