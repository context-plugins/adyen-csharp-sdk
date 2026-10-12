using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostAccountHolderBalance operation.
/// </summary>
public sealed record PostAccountHolderBalanceRequest
{
    public CloseAccountHolderRequest? Body { get; init; }
}
