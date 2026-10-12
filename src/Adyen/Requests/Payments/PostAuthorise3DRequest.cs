using Adyen.Models;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostAuthorise3D operation.
/// </summary>
public sealed record PostAuthorise3DRequest
{
    public PaymentRequest3D? Body { get; init; }
}
