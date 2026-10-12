using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostUnSuspendAccountHolder operation.
/// </summary>
public sealed record PostUnSuspendAccountHolderRequest
{
    public UnSuspendAccountHolderRequest? Body { get; init; }
}
