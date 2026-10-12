using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostRefundNotPaidOutTransfers operation.
/// </summary>
public sealed record PostRefundNotPaidOutTransfersRequest
{
    public RefundNotPaidOutTransfersRequest? Body { get; init; }
}
