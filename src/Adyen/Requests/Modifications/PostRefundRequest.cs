using Adyen.Models;

namespace Adyen.Requests.Modifications;

/// <summary>
/// The inputs of the PostRefund operation.
/// </summary>
public sealed record PostRefundRequest
{
    public RefundRequest? Body { get; init; }
}
