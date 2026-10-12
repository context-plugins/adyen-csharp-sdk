namespace Adyen.Requests.BalanceAccounts;

/// <summary>
/// The inputs of the GetBalanceAccountsIdTransactionRules operation.
/// </summary>
public sealed record GetBalanceAccountsIdTransactionRulesRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string Id { get; init; }
}
