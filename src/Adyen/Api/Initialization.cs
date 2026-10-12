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
using Adyen.Requests.Initialization;

namespace Adyen.Api;

public sealed class Initialization
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Initialization(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Store payout details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoreDetailResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostStoreDetailError"/> when the server returns an error response.</exception>
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
    /// Stores payment details under the <c>PAYOUT</c> recurring contract. These payment details can be used later to submit a payout via the <c>/submitThirdParty</c> call.
    /// </para>
    /// </remarks>
    public Task<StoreDetailResponse> PostStoreDetail(PostStoreDetailRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default3("/storeDetail"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StoreDetailResponse>(),
            PostStoreDetailError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Store details and submit a payout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoreDetailAndSubmitResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostStoreDetailAndSubmitThirdPartyError"/> when the server returns an error response.</exception>
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
    /// Submits a payout and stores its details for subsequent payouts.
    /// </para>
    /// <para>
    /// The submitted payout must be confirmed or declined either by a reviewer or via <c>/confirmThirdParty</c> or <c>/declineThirdParty</c> calls.
    /// </para>
    /// </remarks>
    public Task<StoreDetailAndSubmitResponse> PostStoreDetailAndSubmitThirdParty(PostStoreDetailAndSubmitThirdPartyRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default3("/storeDetailAndSubmitThirdParty"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StoreDetailAndSubmitResponse>(),
            PostStoreDetailAndSubmitThirdPartyError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Submit a payout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubmitResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostSubmitThirdPartyError"/> when the server returns an error response.</exception>
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
    /// Submits a payout using the previously stored payment details. To store payment details, use the <c>/storeDetail</c> API call.
    /// </para>
    /// <para>
    /// The submitted payout must be confirmed or declined either by a reviewer or via <c>/confirmThirdParty</c> or <c>/declineThirdParty</c> calls.
    /// </para>
    /// </remarks>
    public Task<SubmitResponse> PostSubmitThirdParty(PostSubmitThirdPartyRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default3("/submitThirdParty"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SubmitResponse>(),
            PostSubmitThirdPartyError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
