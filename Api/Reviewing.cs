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

public sealed class Reviewing
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Reviewing(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Confirm a payout
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModifyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostConfirmThirdPartyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// &gt; This endpoint is <b>deprecated</b> and no longer supports new integrations. Do one of the following:
    /// &gt;- If you are building a new integration, use the <see href="https://docs.adyen.com/api-explorer/transfers/latest/overview">Transfers API</see> instead.
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
    /// Confirms a previously submitted payout.
    /// </para>
    /// <para>
    /// To cancel a payout, use the <c>/declineThirdParty</c> endpoint.
    /// </para>
    /// </remarks>
    public Task<ModifyResponse> PostConfirmThirdParty(ModifyRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default3("/confirmThirdParty"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ModifyResponse>(),
            PostConfirmThirdPartyErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel a payout
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModifyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDeclineThirdPartyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// &gt; This endpoint is <b>deprecated</b> and no longer supports new integrations. Do one of the following:
    /// &gt;- If you are building a new integration, use the <see href="https://docs.adyen.com/api-explorer/transfers/latest/overview">Transfers API</see> instead.
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
    /// Cancels a previously submitted payout.
    /// </para>
    /// <para>
    /// To confirm and send a payout, use the <c>/confirmThirdParty</c> endpoint.
    /// </para>
    /// </remarks>
    public Task<ModifyResponse> PostDeclineThirdParty(ModifyRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default3("/declineThirdParty"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ModifyResponse>(),
            PostDeclineThirdPartyErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
