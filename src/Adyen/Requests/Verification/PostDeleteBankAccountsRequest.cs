using Adyen.Models;

namespace Adyen.Requests.Verification;

/// <summary>
/// The inputs of the PostDeleteBankAccounts operation.
/// </summary>
public sealed record PostDeleteBankAccountsRequest
{
    public DeleteBankAccountRequest? Body { get; init; }
}
