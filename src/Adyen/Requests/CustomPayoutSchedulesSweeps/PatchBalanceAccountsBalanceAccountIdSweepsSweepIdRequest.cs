using Adyen.Models;

namespace Adyen.Requests.CustomPayoutSchedulesSweeps;

/// <summary>
/// The inputs of the PatchBalanceAccountsBalanceAccountIdSweepsSweepId operation.
/// </summary>
public sealed record PatchBalanceAccountsBalanceAccountIdSweepsSweepIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the sweep.
    /// </summary>
    public required string SweepId { get; init; }

    public UpdateSweepConfigurationV2? Body { get; init; }
}
