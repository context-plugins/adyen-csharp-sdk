using Adyen.Models;

namespace Adyen.Requests.RaiseDisputes;

/// <summary>
/// The inputs of the PostDisputes operation.
/// </summary>
public sealed record PostDisputesRequest
{
    public required DisputeRequest Body { get; init; }
}
