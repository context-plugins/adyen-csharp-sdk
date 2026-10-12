using Adyen.Models;

namespace Adyen.Requests.AccountVerification;

/// <summary>
/// The inputs of the PostAccountVerificationRoutes operation.
/// </summary>
public sealed record PostAccountVerificationRoutesRequest
{
    public required AccountVerificationRoutesRequest Body { get; init; }
}
