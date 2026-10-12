using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostUpdateAccountHolder operation.
/// </summary>
public sealed record PostUpdateAccountHolderRequest
{
    public UpdateAccountHolderRequest? Body { get; init; }
}
