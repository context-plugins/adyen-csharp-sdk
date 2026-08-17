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

public sealed class Rates
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Rates(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Calculate amount in a different currency
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculateRateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostRatesCalculateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the calculated amounts and rates required to convert the currency of a transaction.
    /// </remarks>
    public Task<CalculateRateResponse> PostRatesCalculate(CalculateRateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default7("/rates/calculate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CalculateRateResponse>(),
            PostRatesCalculateErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
