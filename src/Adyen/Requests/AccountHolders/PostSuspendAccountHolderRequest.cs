using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostSuspendAccountHolder operation.
/// </summary>
public sealed record PostSuspendAccountHolderRequest
{
    public SuspendAccountHolderRequest? Body { get; init; }
}
