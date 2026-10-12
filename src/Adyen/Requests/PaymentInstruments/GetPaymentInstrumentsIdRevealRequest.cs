namespace Adyen.Requests.PaymentInstruments;

/// <summary>
/// The inputs of the GetPaymentInstrumentsIdReveal operation.
/// </summary>
public sealed record GetPaymentInstrumentsIdRevealRequest
{
    /// <summary>
    /// The unique identifier of the payment instrument.
    /// </summary>
    public required string Id { get; init; }
}
