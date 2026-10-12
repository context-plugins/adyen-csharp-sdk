using Adyen.Models;

namespace Adyen.Requests.PaymentInstrumentGroups;

/// <summary>
/// The inputs of the PostPaymentInstrumentGroups operation.
/// </summary>
public sealed record PostPaymentInstrumentGroupsRequest
{
    public PaymentInstrumentGroupInfo? Body { get; init; }
}
