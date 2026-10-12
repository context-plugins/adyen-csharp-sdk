using Adyen.Models;

namespace Adyen.Requests.RecurringTopUps;

/// <summary>
/// The inputs of the PostBalanceAccountsBalanceAccountIdRecurringTopUps operation.
/// </summary>
public sealed record PostBalanceAccountsBalanceAccountIdRecurringTopUpsRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    public required CreateRecurringTopUp Body { get; init; }
}
