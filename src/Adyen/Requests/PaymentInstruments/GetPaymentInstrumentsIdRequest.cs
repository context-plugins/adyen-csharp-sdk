namespace Adyen.Requests.PaymentInstruments;

/// <summary>
/// The inputs of the GetPaymentInstrumentsId operation.
/// </summary>
public sealed record GetPaymentInstrumentsIdRequest
{
    /// <summary>
    /// The unique identifier of the payment instrument.
    /// </summary>
    public required string Id { get; init; }
}
