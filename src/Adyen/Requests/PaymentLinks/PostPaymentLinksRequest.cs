using Adyen.Models;

namespace Adyen.Requests.PaymentLinks;

/// <summary>
/// The inputs of the PostPaymentLinks operation.
/// </summary>
public sealed record PostPaymentLinksRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public PaymentLinkRequest? Body { get; init; }
}
