namespace Adyen.Requests.PaymentLinks;

/// <summary>
/// The inputs of the GetPaymentLinksLinkId operation.
/// </summary>
public sealed record GetPaymentLinksLinkIdRequest
{
    /// <summary>
    /// Unique identifier of the payment link.
    /// </summary>
    public required string LinkId { get; init; }
}
