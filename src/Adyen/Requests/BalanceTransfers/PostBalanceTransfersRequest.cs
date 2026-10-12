using Adyen.Models;

namespace Adyen.Requests.BalanceTransfers;

/// <summary>
/// The inputs of the PostBalanceTransfers operation.
/// </summary>
public sealed record PostBalanceTransfersRequest
{
    public required BalanceTransferRequest Body { get; init; }
}
