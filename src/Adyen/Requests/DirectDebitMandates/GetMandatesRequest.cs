namespace Adyen.Requests.DirectDebitMandates;

/// <summary>
/// The inputs of the GetMandates operation.
/// </summary>
public sealed record GetMandatesRequest
{
    /// <summary>
    /// The unique identifier of the balance account linked to the payment instrument.
    /// </summary>
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument linked to the mandate.
    /// </summary>
    public string? PaymentInstrumentId { get; init; }

    /// <summary>
    /// The pagination cursor returned in a previous GET <c>/mandates</c> request.
    /// </summary>
    public string? Cursor { get; init; }
}
