namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the GetAccountHoldersIdBalanceAccounts operation.
/// </summary>
public sealed record GetAccountHoldersIdBalanceAccountsRequest
{
    /// <summary>
    /// The unique identifier of the account holder.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The number of items that you want to skip.
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.
    /// </summary>
    public int? Limit { get; init; }
}
