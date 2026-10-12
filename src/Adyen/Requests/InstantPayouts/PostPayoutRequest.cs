using Adyen.Models;

namespace Adyen.Requests.InstantPayouts;

/// <summary>
/// The inputs of the PostPayout operation.
/// </summary>
public sealed record PostPayoutRequest
{
    public PayoutRequest? Body { get; init; }
}
