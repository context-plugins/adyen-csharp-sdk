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
using Adyen.Requests.TransferRoutes;

namespace Adyen.Api;

public sealed class TransferRoutes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TransferRoutes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Calculate transfer routes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRouteResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTransferRoutesCalculateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns available transfer routes based on a combination of transfer <c>country</c>, <c>currency</c>, <c>counterparty</c>, and <c>priorities</c>. Use this endpoint to find optimal transfer priorities and associated requirements before you <see href="https://docs.adyen.com/api-explorer/transfers/latest/post/transfers">make a transfer</see>.
    /// </remarks>
    public Task<TransferRouteResponse> PostTransferRoutesCalculate(PostTransferRoutesCalculateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/transferRoutes/calculate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferRouteResponse>(),
            PostTransferRoutesCalculateError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
