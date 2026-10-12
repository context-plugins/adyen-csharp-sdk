using Adyen.Models;

namespace Adyen.Requests.CustomPayoutSchedulesSweeps;

/// <summary>
/// The inputs of the PostBalanceAccountsBalanceAccountIdSweeps operation.
/// </summary>
public sealed record PostBalanceAccountsBalanceAccountIdSweepsRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    public CreateSweepConfigurationV2? Body { get; init; }
}
