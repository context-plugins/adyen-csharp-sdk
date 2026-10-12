using Adyen.Models;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostAuthorise3Ds2 operation.
/// </summary>
public sealed record PostAuthorise3Ds2Request
{
    public PaymentRequest3Ds2? Body { get; init; }
}
