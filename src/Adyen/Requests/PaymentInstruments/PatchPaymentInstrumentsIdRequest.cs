using Adyen.Models;

namespace Adyen.Requests.PaymentInstruments;

/// <summary>
/// The inputs of the PatchPaymentInstrumentsId operation.
/// </summary>
public sealed record PatchPaymentInstrumentsIdRequest
{
    /// <summary>
    /// The unique identifier of the payment instrument.
    /// </summary>
    public required string Id { get; init; }

    public PaymentInstrumentUpdateRequest? Body { get; init; }
}
