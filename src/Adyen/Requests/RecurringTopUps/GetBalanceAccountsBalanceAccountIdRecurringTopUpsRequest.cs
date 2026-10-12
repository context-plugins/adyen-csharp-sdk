using Adyen.Core.Validation.Attributes;

namespace Adyen.Requests.RecurringTopUps;

/// <summary>
/// The inputs of the GetBalanceAccountsBalanceAccountIdRecurringTopUps operation.
/// </summary>
public sealed record GetBalanceAccountsBalanceAccountIdRecurringTopUpsRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The number of items to return per page. Value must be between 1 and 100.
    /// </summary>
    [Minimum(1)]
    [Maximum(100)]
    public int Limit { get; init; } = 10;

    /// <summary>
    /// The cursor used for pagination. Required if you want to see the next or previous page of results.
    /// </summary>
    public string? Cursor { get; init; }
}
