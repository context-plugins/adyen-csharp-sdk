namespace Adyen.Requests.PaymentInstrumentGroups;

/// <summary>
/// The inputs of the GetPaymentInstrumentGroupsIdTransactionRules operation.
/// </summary>
public sealed record GetPaymentInstrumentGroupsIdTransactionRulesRequest
{
    /// <summary>
    /// The unique identifier of the payment instrument group.
    /// </summary>
    public required string Id { get; init; }
}
