using Adyen.Models;

namespace Adyen.Requests.Verification;

/// <summary>
/// The inputs of the PostDeletePayoutMethods operation.
/// </summary>
public sealed record PostDeletePayoutMethodsRequest
{
    public DeletePayoutMethodRequest? Body { get; init; }
}
