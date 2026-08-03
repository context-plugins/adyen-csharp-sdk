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
    /// get-balanceOverview-companies-companyAccountCode-balances
    /// </summary>
    /// <param name="companyAccountCode">The unique identifier of your company account.</param>
    /// <param name="currency">The currency for which you want a balances overview.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyBalances"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError"/> when the server returns an error response.</exception>
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
    public Task<CompanyBalances> GetBalanceOverviewCompaniesCompanyAccountCodeBalances(string companyAccountCode,
        string currency,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceOverview/companies/{companyAccountCode}/balances"),
            [new TemplateParam("companyAccountCode", companyAccountCode)],
            [new Param("currency", currency)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CompanyBalances>(),
            GetBalanceOverviewCompaniesCompanyAccountCodeBalancesErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// get-balanceOverview-merchants-merchantAccountCode-balances
    /// </summary>
    /// <param name="merchantAccountCode">The unique identifier of your merchant account.</param>
    /// <param name="currency">The currency for which you want a balances overview.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MerchantBalance"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError"/> when the server returns an error response.</exception>
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
    public Task<MerchantBalance> GetBalanceOverviewMerchantsMerchantAccountCodeBalances(string merchantAccountCode,
        string currency,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceOverview/merchants/{merchantAccountCode}/balances"),
            [new TemplateParam("merchantAccountCode", merchantAccountCode)],
            [new Param("currency", currency)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MerchantBalance>(),
            GetBalanceOverviewMerchantsMerchantAccountCodeBalancesErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
