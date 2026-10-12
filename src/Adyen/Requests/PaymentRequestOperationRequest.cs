using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the PaymentRequest operation.
/// </summary>
public sealed record PaymentRequestOperationRequest
{
    public PaymentRequest2? Body { get; init; }
}
