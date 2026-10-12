using Adyen.Models;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostPaymentMethods operation.
/// </summary>
public sealed record PostPaymentMethodsRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public PaymentMethodsRequest? Body { get; init; }
}
