using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the BalanceInquiryRequest operation.
/// </summary>
public sealed record BalanceInquiryRequestOperationRequest
{
    public BalanceInquiryRequest? Body { get; init; }
}
