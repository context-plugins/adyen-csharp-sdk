using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostMergeBalance operation.
/// </summary>
public sealed record PostMergeBalanceRequest
{
    public StoredValueBalanceMergeRequest? Body { get; init; }
}
