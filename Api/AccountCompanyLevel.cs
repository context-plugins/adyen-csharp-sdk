using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class AccountCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-companies
    /// </summary>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCompanyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of company accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Management API—Account read</description></item>
    /// </list>
    /// </remarks>
    public Task<ListCompanyResponse> GetCompanies(int? pageNumber,
        int? pageSize,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies"),
            [],
            [new Param("pageNumber", pageNumber), new Param("pageSize", pageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCompanyResponse>(),
            GetCompaniesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Company2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the company account specified in the path. Your API credential must have access to the company account.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Account read
    /// </para>
    /// </remarks>
    public Task<Company2> GetCompaniesCompanyId(string companyId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}"),
            [new TemplateParam("companyId", companyId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Company2>(),
            GetCompaniesCompanyIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-merchants
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdMerchantsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of merchant accounts under the company account specified in the path. The list only includes merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Account read
    /// </para>
    /// </remarks>
    public Task<ListMerchantResponse> GetCompaniesCompanyIdMerchants(string companyId,
        int? pageNumber,
        int? pageSize,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/merchants"),
            [new TemplateParam("companyId", companyId)],
            [new Param("pageNumber", pageNumber), new Param("pageSize", pageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantResponse>(),
            GetCompaniesCompanyIdMerchantsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
