using System.ComponentModel.DataAnnotations;

namespace Adyen.Requests.BalancesOverview;

/// <summary>
/// The inputs of the GetBalanceOverviewCompaniesCompanyAccountCodeBalances operation.
/// </summary>
public sealed record GetBalanceOverviewCompaniesCompanyAccountCodeBalancesRequest
{
    /// <summary>
    /// The unique identifier of your company account.
    /// </summary>
    public required string CompanyAccountCode { get; init; }

    /// <summary>
    /// The currency for which you want a balances overview.
    /// </summary>
    [MinLength(1)]
    public required string Currency { get; init; }
}
