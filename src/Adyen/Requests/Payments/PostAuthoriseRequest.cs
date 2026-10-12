using Adyen.Models;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostAuthorise operation.
/// </summary>
public sealed record PostAuthoriseRequest
{
    public PaymentRequest1? Body { get; init; }
}
