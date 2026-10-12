using Adyen.Models;

namespace Adyen.Requests.PaymentInstruments;

/// <summary>
/// The inputs of the PostPaymentInstrumentsIdNetworkTokenActivationData operation.
/// </summary>
public sealed record PostPaymentInstrumentsIdNetworkTokenActivationDataRequest
{
    /// <summary>
    /// The unique identifier of the payment instrument.
    /// </summary>
    public required string Id { get; init; }

    public NetworkTokenActivationDataRequest? Body { get; init; }
}
