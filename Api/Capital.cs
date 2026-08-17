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

public sealed class Capital
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Capital(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a capital account
    /// </summary>
    /// <param name="counterpartyAccountHolderId">The counterparty account holder id.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CapitalGrants"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of grants with status and outstanding balances.
    /// </remarks>
    public Task<CapitalGrants> GetGrants(string? counterpartyAccountHolderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/grants"),
            [],
            [new Param("counterpartyAccountHolderId", counterpartyAccountHolderId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CapitalGrants>(),
            GetGrantsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get grant reference details
    /// </summary>
    /// <param name="id">The unique identifier of the grant.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CapitalGrant"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a capital account specified in the path.
    /// </remarks>
    public Task<CapitalGrant> GetGrantsId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/grants/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CapitalGrant>(),
            GetGrantsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Request a grant payout
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CapitalGrant"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGrantsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Requests the payout of the selected grant offer.
    /// </remarks>
    public Task<CapitalGrant> PostGrants(string? idempotencyKey,
        CapitalGrantInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/grants"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CapitalGrant>(),
            PostGrantsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
