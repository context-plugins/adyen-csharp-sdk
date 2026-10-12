namespace Adyen.Requests.PaymentInstruments;

/// <summary>
/// The inputs of the GetPaymentInstrumentsIdNetworkTokens operation.
/// </summary>
public sealed record GetPaymentInstrumentsIdNetworkTokensRequest
{
    /// <summary>
    /// The unique identifier of the payment instrument.
    /// </summary>
    public required string Id { get; init; }
}
