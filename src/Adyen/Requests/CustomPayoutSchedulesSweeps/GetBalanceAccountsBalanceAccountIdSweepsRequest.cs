namespace Adyen.Requests.CustomPayoutSchedulesSweeps;

/// <summary>
/// The inputs of the GetBalanceAccountsBalanceAccountIdSweeps operation.
/// </summary>
public sealed record GetBalanceAccountsBalanceAccountIdSweepsRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The number of items that you want to skip.
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.
    /// </summary>
    public int? Limit { get; init; }
}
