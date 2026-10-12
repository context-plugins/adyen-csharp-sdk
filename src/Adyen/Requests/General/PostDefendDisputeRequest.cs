using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostDefendDispute operation.
/// </summary>
public sealed record PostDefendDisputeRequest
{
    public DefendDisputeRequest? Body { get; init; }
}
