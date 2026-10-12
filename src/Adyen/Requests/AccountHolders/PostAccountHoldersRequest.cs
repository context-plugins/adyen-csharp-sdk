using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostAccountHolders operation.
/// </summary>
public sealed record PostAccountHoldersRequest
{
    public AccountHolderInfo? Body { get; init; }
}
