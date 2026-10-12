namespace Adyen.Requests.PaymentInstruments;

/// <summary>
/// The inputs of the GetPaymentInstrumentsIdTransactionRules operation.
/// </summary>
public sealed record GetPaymentInstrumentsIdTransactionRulesRequest
{
    /// <summary>
    /// The unique identifier of the payment instrument.
    /// </summary>
    public required string Id { get; init; }
}
