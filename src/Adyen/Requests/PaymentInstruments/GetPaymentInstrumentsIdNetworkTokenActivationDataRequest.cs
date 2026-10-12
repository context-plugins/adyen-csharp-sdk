namespace Adyen.Requests.PaymentInstruments;

/// <summary>
/// The inputs of the GetPaymentInstrumentsIdNetworkTokenActivationData operation.
/// </summary>
public sealed record GetPaymentInstrumentsIdNetworkTokenActivationDataRequest
{
    /// <summary>
    /// The unique identifier of the payment instrument.
    /// </summary>
    public required string Id { get; init; }
}
