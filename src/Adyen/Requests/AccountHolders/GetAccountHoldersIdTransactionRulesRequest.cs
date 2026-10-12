namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the GetAccountHoldersIdTransactionRules operation.
/// </summary>
public sealed record GetAccountHoldersIdTransactionRulesRequest
{
    /// <summary>
    /// The unique identifier of the account holder.
    /// </summary>
    public required string Id { get; init; }
}
