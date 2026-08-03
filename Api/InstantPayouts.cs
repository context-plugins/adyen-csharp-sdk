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

public sealed class InstantPayouts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal InstantPayouts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// post-payout
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPayoutError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// &gt; This endpoint is <b>deprecated</b> and no longer supports new integrations. Do one of the following:
    /// &gt;- If you are building a new integration, use the POST <see href="https://docs.adyen.com/api-explorer/transfers/latest/post/transfers">/transfers</see> endpoint instead.
    /// &gt; - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
    /// &gt;
    /// &gt; With the Transfers API, you can:
    /// &gt; - Handle multiple payout use cases with a single API.
    /// &gt; - Use new payout functionalities, such as instant payouts to bank accounts.
    /// &gt; - Receive webhooks with more details and defined transfer states.
    /// &gt;
    /// &gt; For more information about the payout features of the Transfers API, see our <see href="https://docs.adyen.com/payouts/payout-service">Payouts</see> documentation.
    /// <para>
    ///
    /// With this call, you can pay out to your customers, and funds will be made available within 30 minutes on the cardholder's bank account (this is dependent on whether the issuer supports this functionality). Instant card payouts are only supported for Visa and Mastercard cards.
    /// </para>
    /// </remarks>
    public Task<PayoutResponse> PostPayout(PayoutRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payout"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PayoutResponse>(),
            PostPayoutErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
