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

public sealed class GrantAccounts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GrantAccounts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a grant account
    /// </summary>
    /// <param name="id">The unique identifier of the grant account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CapitalGrantAccount"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantAccountsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the <see href="https://docs.adyen.com/platforms/capital#grant-account">grant account</see>.
    /// </remarks>
    public Task<CapitalGrantAccount> GetGrantAccountsId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/grantAccounts/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CapitalGrantAccount>(),
            GetGrantAccountsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the information of your grant account
    /// </summary>
    /// <param name="id">The unique identifier of the grant account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantAccount"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantAccountsId1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the specified grant account. This account tracks existing grants in your marketplace or platform.
    /// </remarks>
    public Task<GrantAccount> GetGrantAccountsId1(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/grantAccounts/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GrantAccount>(),
            GetGrantAccountsId1ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
