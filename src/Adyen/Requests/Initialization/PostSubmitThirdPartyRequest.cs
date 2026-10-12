using Adyen.Models;

namespace Adyen.Requests.Initialization;

/// <summary>
/// The inputs of the PostSubmitThirdParty operation.
/// </summary>
public sealed record PostSubmitThirdPartyRequest
{
    public SubmitRequest? Body { get; init; }
}
