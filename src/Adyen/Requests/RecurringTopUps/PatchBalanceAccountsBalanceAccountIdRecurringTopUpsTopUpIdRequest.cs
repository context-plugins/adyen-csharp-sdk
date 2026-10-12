using Adyen.Models;

namespace Adyen.Requests.RecurringTopUps;

/// <summary>
/// The inputs of the PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId operation.
/// </summary>
public sealed record PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the recurring top-up you want to update.
    /// </summary>
    public required string TopUpId { get; init; }

    public required PatchableCreateRecurringTopUp Body { get; init; }
}
