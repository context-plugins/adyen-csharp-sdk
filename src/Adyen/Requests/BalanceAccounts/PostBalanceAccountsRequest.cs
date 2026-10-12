using Adyen.Models;

namespace Adyen.Requests.BalanceAccounts;

/// <summary>
/// The inputs of the PostBalanceAccounts operation.
/// </summary>
public sealed record PostBalanceAccountsRequest
{
    public BalanceAccountInfo? Body { get; init; }
}
