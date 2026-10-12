using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;
using Adyen.Requests.BalancesOverview;

namespace Adyen.Api;

public sealed class BalancesOverview
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal BalancesOverview(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// View the available balances for all merchant accounts under your company.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyBalances"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an array with details about the balances available for all merchant accounts under your company account. For each merchant account, the response returns the following:
    /// <list type="bullet">
    ///   <item><description><b>Available funds</b>: The funds in the merchant account that have been settled and are available for use.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Pending balance</b>: The funds in the merchant account that have not been settled yet.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Next payout amount</b>: The amount that will be settled to your bank account with the next payout.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Reserve</b>: The available amount to cover refunds, payouts, chargebacks, and other operational expenses that cannot be covered by your in-process funds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Deposit</b>: The amount withheld by Adyen to cover potential losses and liabilities due to payment processing.</description></item>
    /// </list>
    /// </remarks>
    public Task<CompanyBalances> GetBalanceOverviewCompaniesCompanyAccountCodeBalances(GetBalanceOverviewCompaniesCompanyAccountCodeBalancesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default11("/balanceOverview/companies/{companyAccountCode}/balances"),
            [new TemplateParam("companyAccountCode", request.CompanyAccountCode)],
            [new Param("currency", request.Currency)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CompanyBalances>(),
            GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// View all balances available for your merchant account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MerchantBalance"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an overview of the different balances available for the merchant account. This includes details about the following:
    /// <list type="bullet">
    ///   <item><description><b>Available funds</b>: The funds in the merchant account that have been settled and are available for use.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Pending balance</b>: The funds in the merchant account that have not been settled yet.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Next payout amount</b>: The amount that will be settled to your bank account with the next payout.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Reserve</b>: The available amount to cover refunds, payouts, chargebacks, and other operational expenses that cannot be covered by your in-process funds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Deposit</b>: The amount withheld by Adyen to cover potential losses and liabilities due to payment processing.</description></item>
    /// </list>
    /// </remarks>
    public Task<MerchantBalance> GetBalanceOverviewMerchantsMerchantAccountCodeBalances(GetBalanceOverviewMerchantsMerchantAccountCodeBalancesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default11("/balanceOverview/merchants/{merchantAccountCode}/balances"),
            [new TemplateParam("merchantAccountCode", request.MerchantAccountCode)],
            [new Param("currency", request.Currency)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MerchantBalance>(),
            GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError.Response,
            [],
            requestOptions,
            cancellationToken);
}
