namespace Adyen.Requests.BalanceAccounts;

/// <summary>
/// The inputs of the GetBalanceAccountsId operation.
/// </summary>
public sealed record GetBalanceAccountsIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string Id { get; init; }
}
