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

public sealed class Platform
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Platform(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a balance platform
    /// </summary>
    /// <param name="id">The unique identifier of the balance platform.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalancePlatform"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalancePlatformsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a balance platform.
    /// </remarks>
    public Task<BalancePlatform> GetBalancePlatformsId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balancePlatforms/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalancePlatform>(),
            GetBalancePlatformsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all account holders under a balance platform
    /// </summary>
    /// <param name="id">The unique identifier of the balance platform.</param>
    /// <param name="offset">The number of items that you want to skip.</param>
    /// <param name="limit">The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedAccountHoldersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalancePlatformsIdAccountHoldersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of all the account holders that belong to the balance platform. To fetch multiple pages, use the query parameters.
    /// <para>
    /// For example, to limit the page to 5 account holders and to skip the first 20, use <c>/balancePlatforms/{id}/accountHolders?limit=5&amp;offset=20</c>.
    /// </para>
    /// </remarks>
    public Task<PaginatedAccountHoldersResponse> GetBalancePlatformsIdAccountHolders(string id,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balancePlatforms/{id}/accountHolders"),
            [new TemplateParam("id", id)],
            [new Param("offset", offset), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedAccountHoldersResponse>(),
            GetBalancePlatformsIdAccountHoldersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all transaction rules for a balance platform
    /// </summary>
    /// <param name="id">The unique identifier of the balance platform.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRulesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalancePlatformsIdTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of transaction rules associated with a balance platform.
    /// </remarks>
    public Task<TransactionRulesResponse> GetBalancePlatformsIdTransactionRules(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balancePlatforms/{id}/transactionRules"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRulesResponse>(),
            GetBalancePlatformsIdTransactionRulesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
