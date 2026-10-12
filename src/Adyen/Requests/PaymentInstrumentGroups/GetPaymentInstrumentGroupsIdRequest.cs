namespace Adyen.Requests.PaymentInstrumentGroups;

/// <summary>
/// The inputs of the GetPaymentInstrumentGroupsId operation.
/// </summary>
public sealed record GetPaymentInstrumentGroupsIdRequest
{
    /// <summary>
    /// The unique identifier of the payment instrument group.
    /// </summary>
    public required string Id { get; init; }
}
