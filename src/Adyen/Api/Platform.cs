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
using Adyen.Requests.Platform;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalancePlatform"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalancePlatformsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a balance platform.
    /// </remarks>
    public Task<BalancePlatform> GetBalancePlatformsId(GetBalancePlatformsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalancePlatform>(),
            GetBalancePlatformsIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all account holders under a balance platform
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedAccountHoldersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalancePlatformsIdAccountHoldersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of all the account holders that belong to the balance platform. To fetch multiple pages, use the query parameters.
    /// <para>
    /// For example, to limit the page to 5 account holders and to skip the first 20, use <c>/balancePlatforms/{id}/accountHolders?limit=5&amp;offset=20</c>.
    /// </para>
    /// </remarks>
    public Task<PaginatedAccountHoldersResponse> GetBalancePlatformsIdAccountHolders(GetBalancePlatformsIdAccountHoldersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{id}/accountHolders"),
            [new TemplateParam("id", request.Id)],
            [new Param("offset", request.Offset), new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedAccountHoldersResponse>(),
            GetBalancePlatformsIdAccountHoldersError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all transaction rules for a balance platform
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRulesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalancePlatformsIdTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of transaction rules associated with a balance platform.
    /// </remarks>
    public Task<TransactionRulesResponse> GetBalancePlatformsIdTransactionRules(GetBalancePlatformsIdTransactionRulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{id}/transactionRules"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRulesResponse>(),
            GetBalancePlatformsIdTransactionRulesError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
