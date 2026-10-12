using Adyen.Models;

namespace Adyen.Requests.PaymentInstruments;

/// <summary>
/// The inputs of the PostPaymentInstruments operation.
/// </summary>
public sealed record PostPaymentInstrumentsRequest
{
    public PaymentInstrumentInfo? Body { get; init; }
}
