using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostCreateAccountHolder operation.
/// </summary>
public sealed record PostCreateAccountHolderRequest
{
    public CreateAccountHolderRequest? Body { get; init; }
}
