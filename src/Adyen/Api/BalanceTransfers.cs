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
using Adyen.Requests.BalanceTransfers;

namespace Adyen.Api;

public sealed class BalanceTransfers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal BalanceTransfers(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Performs a balance transfer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostBalanceTransfersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Performs a balance transfer between merchant accounts. The following conditions must be met before you can successfully transfer balances:
    /// * The source and destination merchant accounts must be under the same company account and legal entity.
    /// * The source merchant account must have sufficient funds.
    /// * The source and destination merchant accounts must have at least one common processing currency.\n\n
    /// When sending multiple API requests with the same source and destination merchant accounts, send the requests sequentially and *not* in parallel. Some requests may not be processed if the requests are sent in parallel.
    /// </remarks>
    public Task<BalanceTransferResponse> PostBalanceTransfers(PostBalanceTransfersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default11("/balanceTransfers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BalanceTransferResponse>(),
            PostBalanceTransfersError.Response,
            [],
            requestOptions,
            cancellationToken);
}
