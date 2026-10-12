using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostRefundFundsTransfer operation.
/// </summary>
public sealed record PostRefundFundsTransferRequest
{
    public RefundFundsTransferRequest? Body { get; init; }
}
