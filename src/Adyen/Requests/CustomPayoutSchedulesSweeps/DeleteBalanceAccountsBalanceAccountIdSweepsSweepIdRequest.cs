namespace Adyen.Requests.CustomPayoutSchedulesSweeps;

/// <summary>
/// The inputs of the DeleteBalanceAccountsBalanceAccountIdSweepsSweepId operation.
/// </summary>
public sealed record DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdRequest
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
