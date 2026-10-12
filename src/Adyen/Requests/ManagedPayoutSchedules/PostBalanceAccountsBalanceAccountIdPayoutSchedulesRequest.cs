using Adyen.Models;

namespace Adyen.Requests.ManagedPayoutSchedules;

/// <summary>
/// The inputs of the PostBalanceAccountsBalanceAccountIdPayoutSchedules operation.
/// </summary>
public sealed record PostBalanceAccountsBalanceAccountIdPayoutSchedulesRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    public required BalanceAccountConfigurationRequest Body { get; init; }
}
