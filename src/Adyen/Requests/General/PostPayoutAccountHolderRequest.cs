using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostPayoutAccountHolder operation.
/// </summary>
public sealed record PostPayoutAccountHolderRequest
{
    public PayoutAccountHolderRequest? Body { get; init; }
}
