using Adyen.Models;

namespace Adyen.Requests.TransferRoutes;

/// <summary>
/// The inputs of the PostTransferRoutesCalculate operation.
/// </summary>
public sealed record PostTransferRoutesCalculateRequest
{
    public TransferRouteRequest? Body { get; init; }
}
