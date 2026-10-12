using Adyen.Models;

namespace Adyen.Requests.ManagedPayoutSchedules;

/// <summary>
/// The inputs of the PatchBalanceAccountsBalanceAccountIdPayoutSchedulesId operation.
/// </summary>
public sealed record PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the payout schedule applied to the balance account.
    /// </summary>
    public required string Id { get; init; }

    public required BalanceAccountConfigurationUpdate Body { get; init; }
}
