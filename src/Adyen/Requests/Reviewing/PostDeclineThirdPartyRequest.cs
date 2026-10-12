using Adyen.Models;

namespace Adyen.Requests.Reviewing;

/// <summary>
/// The inputs of the PostDeclineThirdParty operation.
/// </summary>
public sealed record PostDeclineThirdPartyRequest
{
    public ModifyRequest? Body { get; init; }
}
