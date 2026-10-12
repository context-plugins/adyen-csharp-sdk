using System.Collections.Generic;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Requests.ManagedPayoutSchedules;

/// <summary>
/// The inputs of the GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutions operation.
/// </summary>
public sealed record GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the payout schedule on the balance account.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The page number to be returned.
    /// <para>
    /// Default: <b>1</b>
    /// </para>
    /// </summary>
    [Minimum(1)]
    [Maximum(100)]
    public required int Offset { get; init; }

    /// <summary>
    /// Contains a list of payout statuses. If included, the response returns only executed payouts that currently have one of the specified statuses.
    /// <para>
    /// Possible statuses:
    /// - <b>succeeded</b>: The payout was sent successfully.
    /// - <b>failed</b>: The payout was not sent due to an error.
    /// - <b>skipped</b>: The payout was not triggered as expected.
    /// </para>
    /// </summary>
    public IReadOnlyList<ExecutionResult>? Results { get; init; }

    /// <summary>
    /// The number of items returned per page.
    /// <para>
    /// Default: <b>10</b>
    /// </para>
    /// </summary>
    [Minimum(10)]
    public int? Limit { get; init; }
}
