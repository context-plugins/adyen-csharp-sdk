using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostCloseAccountHolder operation.
/// </summary>
public sealed record PostCloseAccountHolderRequest
{
    public CloseAccountHolderRequest? Body { get; init; }
}
