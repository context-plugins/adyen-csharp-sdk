using Adyen.Models;

namespace Adyen.Requests.Modifications;

/// <summary>
/// The inputs of the PostCancelOrRefund operation.
/// </summary>
public sealed record PostCancelOrRefundRequest
{
    public CancelOrRefundRequest? Body { get; init; }
}
