using Adyen.Models;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostPaymentsDetails operation.
/// </summary>
public sealed record PostPaymentsDetailsRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public PaymentDetailsRequest? Body { get; init; }
}
