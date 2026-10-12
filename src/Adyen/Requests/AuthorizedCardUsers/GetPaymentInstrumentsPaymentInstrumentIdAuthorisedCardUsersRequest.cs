namespace Adyen.Requests.AuthorizedCardUsers;

/// <summary>
/// The inputs of the GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers operation.
/// </summary>
public sealed record GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest
{
    public required string PaymentInstrumentId { get; init; }
}
