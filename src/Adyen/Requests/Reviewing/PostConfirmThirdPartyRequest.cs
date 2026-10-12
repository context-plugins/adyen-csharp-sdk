using Adyen.Models;

namespace Adyen.Requests.Reviewing;

/// <summary>
/// The inputs of the PostConfirmThirdParty operation.
/// </summary>
public sealed record PostConfirmThirdPartyRequest
{
    public ModifyRequest? Body { get; init; }
}
