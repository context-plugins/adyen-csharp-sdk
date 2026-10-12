using Adyen.Models;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostPaymentsCancel operation.
/// </summary>
public sealed record PostPaymentsCancelRequest
{
    public required CancelPaymentRequest Body { get; init; }
}
