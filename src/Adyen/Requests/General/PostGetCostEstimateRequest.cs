using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostGetCostEstimate operation.
/// </summary>
public sealed record PostGetCostEstimateRequest
{
    public CostEstimateRequest? Body { get; init; }
}
