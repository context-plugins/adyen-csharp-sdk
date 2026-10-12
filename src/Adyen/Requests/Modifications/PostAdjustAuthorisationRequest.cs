using Adyen.Models;

namespace Adyen.Requests.Modifications;

/// <summary>
/// The inputs of the PostAdjustAuthorisation operation.
/// </summary>
public sealed record PostAdjustAuthorisationRequest
{
    public AdjustAuthorisationRequest? Body { get; init; }
}
