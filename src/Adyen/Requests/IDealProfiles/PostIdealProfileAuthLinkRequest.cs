using Adyen.Models;

namespace Adyen.Requests.IDealProfiles;

/// <summary>
/// The inputs of the PostIdealProfileAuthLink operation.
/// </summary>
public sealed record PostIdealProfileAuthLinkRequest
{
    public required IdealAuthLinkRequest Body { get; init; }
}
