namespace Adyen.Requests.AuthorizedCardUsers;

/// <summary>
/// The inputs of the DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers operation.
/// </summary>
public sealed record DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest
{
    public required string PaymentInstrumentId { get; init; }
}
