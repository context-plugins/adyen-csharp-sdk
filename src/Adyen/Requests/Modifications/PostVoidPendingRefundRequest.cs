using Adyen.Models;

namespace Adyen.Requests.Modifications;

/// <summary>
/// The inputs of the PostVoidPendingRefund operation.
/// </summary>
public sealed record PostVoidPendingRefundRequest
{
    public VoidPendingRefundRequest? Body { get; init; }
}
