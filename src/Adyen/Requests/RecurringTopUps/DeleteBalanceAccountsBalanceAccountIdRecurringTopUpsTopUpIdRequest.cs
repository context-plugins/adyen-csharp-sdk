namespace Adyen.Requests.RecurringTopUps;

/// <summary>
/// The inputs of the DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId operation.
/// </summary>
public sealed record DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the recurring top-up you want to delete.
    /// </summary>
    public required string TopUpId { get; init; }
}
