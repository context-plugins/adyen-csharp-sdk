using Adyen.Models;

namespace Adyen.Requests.PaymentInstruments;

/// <summary>
/// The inputs of the PostPaymentInstrumentsReveal operation.
/// </summary>
public sealed record PostPaymentInstrumentsRevealRequest
{
    public PaymentInstrumentRevealRequest? Body { get; init; }
}
