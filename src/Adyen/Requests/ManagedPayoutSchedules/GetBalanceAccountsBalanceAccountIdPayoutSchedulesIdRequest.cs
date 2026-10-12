namespace Adyen.Requests.ManagedPayoutSchedules;

/// <summary>
/// The inputs of the GetBalanceAccountsBalanceAccountIdPayoutSchedulesId operation.
/// </summary>
public sealed record GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the payout schedule for the balance account.
    /// </summary>
    public required string Id { get; init; }
}
