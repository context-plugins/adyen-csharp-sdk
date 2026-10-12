using Adyen.Core.Validation.Attributes;

namespace Adyen.Requests.ManagedPayoutSchedules;

/// <summary>
/// The inputs of the GetBalanceAccountsBalanceAccountIdPayoutSchedules operation.
/// </summary>
public sealed record GetBalanceAccountsBalanceAccountIdPayoutSchedulesRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> of the currency used in the payout schedule.
    /// </summary>
    public string? Currency { get; init; }

    /// <summary>
    /// The <c>cursor</c> returned in the links of the previous response.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page.
    /// </summary>
    [Minimum(1)]
    [Maximum(100)]
    public int Limit { get; init; } = 10;
}
