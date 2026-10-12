using Adyen.Models;

namespace Adyen.Requests.Modifications;

/// <summary>
/// The inputs of the PostPaymentsPaymentPspReferenceReversals operation.
/// </summary>
public sealed record PostPaymentsPaymentPspReferenceReversalsRequest
{
    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference"><c>pspReference</c></see> of the payment that you want to reverse.
    /// </summary>
    public required string PaymentPspReference { get; init; }

    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public PaymentReversalRequest? Body { get; init; }
}
