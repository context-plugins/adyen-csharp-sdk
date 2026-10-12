using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostUpdateAccountHolderState operation.
/// </summary>
public sealed record PostUpdateAccountHolderStateRequest
{
    public UpdateAccountHolderStateRequest? Body { get; init; }
}
