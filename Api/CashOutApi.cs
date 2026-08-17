using System;
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

public sealed class CashOutApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal CashOutApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Initiate a cashout
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CashOut"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCashoutsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates a <see href="https://docs.adyen.com/platforms/cash-out-instantly">cashout</see> request.
    /// </remarks>
    public Task<CashOut> PostCashouts(CashOutInfo body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/cashouts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CashOut>(),
            PostCashoutsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
