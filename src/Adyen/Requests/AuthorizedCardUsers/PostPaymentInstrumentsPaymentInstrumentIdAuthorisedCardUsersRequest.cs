using Adyen.Models;

namespace Adyen.Requests.AuthorizedCardUsers;

/// <summary>
/// The inputs of the PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers operation.
/// </summary>
public sealed record PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest
{
    public required string PaymentInstrumentId { get; init; }

    public required AuthorisedCardUsers Body { get; init; }
}
