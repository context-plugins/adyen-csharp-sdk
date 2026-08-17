using System;
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

public sealed class NetworkTokens
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal NetworkTokens(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a network token
    /// </summary>
    /// <param name="networkTokenId">The unique identifier of the network token.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetNetworkTokenResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetNetworkTokensNetworkTokenIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a network token.
    /// </remarks>
    public Task<GetNetworkTokenResponse> GetNetworkTokensNetworkTokenId(string networkTokenId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/networkTokens/{networkTokenId}"),
            [new TemplateParam("networkTokenId", networkTokenId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetNetworkTokenResponse>(),
            GetNetworkTokensNetworkTokenIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update a network token
    /// </summary>
    /// <param name="networkTokenId">The unique identifier of the network token.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchNetworkTokensNetworkTokenIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the status of the network token.
    /// </remarks>
    public Task PatchNetworkTokensNetworkTokenId(string networkTokenId,
        UpdateNetworkTokenRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/networkTokens/{networkTokenId}"),
            [new TemplateParam("networkTokenId", networkTokenId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            VoidResponse.Instance,
            PatchNetworkTokensNetworkTokenIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
