namespace Adyen.Requests.CustomPayoutSchedulesSweeps;

/// <summary>
/// The inputs of the GetBalanceAccountsBalanceAccountIdSweepsSweepId operation.
/// </summary>
public sealed record GetBalanceAccountsBalanceAccountIdSweepsSweepIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the sweep.
    /// </summary>
    public required string SweepId { get; init; }
}
