namespace Adyen.Requests.ManagedPayoutSchedules;

/// <summary>
/// The inputs of the DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesId operation.
/// </summary>
public sealed record DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the payout schedule applied to the balance account.
    /// </summary>
    public required string Id { get; init; }
}
