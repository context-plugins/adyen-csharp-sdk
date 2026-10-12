using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostTransferFunds operation.
/// </summary>
public sealed record PostTransferFundsRequest
{
    public TransferFundsRequest? Body { get; init; }
}
