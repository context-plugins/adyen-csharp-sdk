using Adyen.Models;

namespace Adyen.Requests.Verification;

/// <summary>
/// The inputs of the PostCheckAccountHolder operation.
/// </summary>
public sealed record PostCheckAccountHolderRequest
{
    public PerformVerificationRequest? Body { get; init; }
}
