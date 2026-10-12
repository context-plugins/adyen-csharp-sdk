using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostGetAccountHolder operation.
/// </summary>
public sealed record PostGetAccountHolderRequest
{
    public GetAccountHolderRequest? Body { get; init; }
}
