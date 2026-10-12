using System.ComponentModel.DataAnnotations;

namespace Adyen.Requests.BalancesOverview;

/// <summary>
/// The inputs of the GetBalanceOverviewMerchantsMerchantAccountCodeBalances operation.
/// </summary>
public sealed record GetBalanceOverviewMerchantsMerchantAccountCodeBalancesRequest
{
    /// <summary>
    /// The unique identifier of your merchant account.
    /// </summary>
    public required string MerchantAccountCode { get; init; }

    /// <summary>
    /// The currency for which you want a balances overview.
    /// </summary>
    [MinLength(1)]
    public required string Currency { get; init; }
}
