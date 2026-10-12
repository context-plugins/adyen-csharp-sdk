using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostAcceptDispute operation.
/// </summary>
public sealed record PostAcceptDisputeRequest
{
    public AcceptDisputeRequest? Body { get; init; }
}
