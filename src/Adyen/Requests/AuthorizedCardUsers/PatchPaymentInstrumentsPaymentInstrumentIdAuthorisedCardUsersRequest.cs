using Adyen.Models;

namespace Adyen.Requests.AuthorizedCardUsers;

/// <summary>
/// The inputs of the PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers operation.
/// </summary>
public sealed record PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest
{
    public required string PaymentInstrumentId { get; init; }

    public required AuthorisedCardUsers Body { get; init; }
}
