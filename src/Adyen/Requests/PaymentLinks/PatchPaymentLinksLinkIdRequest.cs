using Adyen.Models;

namespace Adyen.Requests.PaymentLinks;

/// <summary>
/// The inputs of the PatchPaymentLinksLinkId operation.
/// </summary>
public sealed record PatchPaymentLinksLinkIdRequest
{
    /// <summary>
    /// Unique identifier of the payment link.
    /// </summary>
    public required string LinkId { get; init; }

    public UpdatePaymentLinkRequest? Body { get; init; }
}
