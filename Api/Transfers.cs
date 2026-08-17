using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.Exceptions;
using Adyen.Core.Extensions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;
using Adyen.Models.Enums;

namespace Adyen.Api;

public sealed class Transfers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Transfers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get all transfers
    /// </summary>
    /// <param name="createdSince">Only include transfers that have been created on or after this point in time. The value must be in ISO 8601 format and not earlier than 6 months before the <c>createdUntil</c> date. For example, <b>2021-05-30T15:07:40Z</b>.</param>
    /// <param name="createdUntil">Only include transfers that have been created on or before this point in time. The value must be in ISO 8601 format and not later than 6 months after the <c>createdSince</c> date. For example, <b>2021-05-30T15:07:40Z</b>.</param>
    /// <param name="balancePlatform">The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id">balance platform</see>.  Required if you don't provide a <c>balanceAccountId</c> or <c>accountHolderId</c>.</param>
    /// <param name="accountHolderId">The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id">account holder</see>.  Required if you don't provide a <c>balanceAccountId</c> or <c>balancePlatform</c>.  If you provide a <c>balanceAccountId</c>, the <c>accountHolderId</c> must be related to the <c>balanceAccountId</c>.</param>
    /// <param name="balanceAccountId">The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id">balance account</see>.  Required if you don't provide an <c>accountHolderId</c> or <c>balancePlatform</c>.  If you provide an <c>accountHolderId</c>, the <c>balanceAccountId</c> must be related to the <c>accountHolderId</c>.</param>
    /// <param name="paymentInstrumentId">The unique identifier of the <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_">payment instrument</see>.  To use this parameter, you must also provide a <c>balanceAccountId</c>, <c>accountHolderId</c>, or <c>balancePlatform</c>.  The <c>paymentInstrumentId</c> must be related to the <c>balanceAccountId</c> or <c>accountHolderId</c> that you provide.</param>
    /// <param name="reference">The reference you provided in the POST <see href="https://docs.adyen.com/api-explorer/transfers/latest/post/transfers">/transfers</see> request</param>
    /// <param name="category">The category of the transfer.  Possible values:   - <b>bank</b>: A transfer involving a <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see> or a bank account.  - <b>card</b>: A transfer involving a third-party card.  - <b>internal</b>: A transfer between <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id">balance accounts</see> within your platform.  - <b>issuedCard</b>: A transfer initiated by an Adyen-issued card.  - <b>platformPayment</b>: Funds movements related to payments that are acquired for your users.  - <b>topUp</b>: An incoming transfer initiated by your user to top up their balance account.</param>
    /// <param name="sortOrder">Determines the sort order of the returned transfers. The sort order is based on the creation date of the transfers.  Possible values:   - <b>asc</b>: Ascending order, from oldest to most recent.  - <b>desc</b>: Descending order, from most recent to oldest.  Default value: <b>asc</b>.</param>
    /// <param name="cursor">The <c>cursor</c> returned in the links of the previous response.</param>
    /// <param name="limit">The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FindTransfersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTransfersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all the transfers related to a balance account, account holder, or balance platform.
    /// <para>
    /// When making this request, you must include at least one of the following:
    /// - <c>balanceAccountId</c>
    /// - <c>accountHolderId</c>
    /// - <c>balancePlatform</c>.
    /// </para>
    /// <para>
    /// This endpoint supports cursor-based pagination. The response returns the first page of results, and returns links to the next and previous pages when applicable. You can use the links to page through the results.
    /// </para>
    /// </remarks>
    public Task<FindTransfersResponse> GetTransfers(DateTimeOffset createdSince,
        DateTimeOffset createdUntil,
        string? balancePlatform,
        string? accountHolderId,
        string? balanceAccountId,
        string? paymentInstrumentId,
        string? reference,
        Category2? category,
        SortOrder? sortOrder,
        string? cursor,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/transfers"),
            [],
            [new Param("createdSince", createdSince.ToIso8601()),
                new Param("createdUntil", createdUntil.ToIso8601()),
                new Param("balancePlatform", balancePlatform),
                new Param("accountHolderId", accountHolderId),
                new Param("balanceAccountId", balanceAccountId),
                new Param("paymentInstrumentId", paymentInstrumentId),
                new Param("reference", reference),
                new Param("category", category),
                new Param("sortOrder", sortOrder),
                new Param("cursor", cursor),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FindTransfersResponse>(),
            GetTransfersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a transfer
    /// </summary>
    /// <param name="id">Unique identifier of the transfer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTransfersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a specified transfer.
    /// </remarks>
    public Task<TransferData> GetTransfersId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/transfers/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransferData>(),
            GetTransfersIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Transfer funds
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="wwwAuthenticate">Header for authenticating through SCA</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Transfer"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTransfersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// &gt;Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.
    /// <para>
    /// Starts a request to transfer funds to:
    /// - <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts">Balance accounts</see>
    /// - <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments">Transfer instruments</see>
    /// - <see href="https://docs.adyen.com/payouts/payout-service/pay-out-to-bank-accounts">Third-party bank accounts</see>
    /// - <see href="https://docs.adyen.com/payouts/payout-service/pay-out-to-cards">Third-party cards</see>
    /// </para>
    /// <para>
    /// Adyen sends the outcome of the transfer request through webhooks.
    /// </para>
    /// <para>
    /// To use this endpoint:
    /// - Your API credential must have the <b>TransferService Webservice Initiate</b> <see href="https://docs.adyen.com/platforms/manage-access/webservice-roles/?tab=transfers_3">role</see>.
    /// - The account holder must have the required <see href="https://docs.adyen.com/platforms/verification-overview/capabilities">capabilities</see>.
    /// </para>
    /// <para>
    /// Reach out to your Adyen contact to set up these permissions.
    /// </para>
    /// </remarks>
    public Task<Transfer> PostTransfers(string? idempotencyKey,
        string? wwwAuthenticate,
        TransferInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/transfers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey), new HeaderParam("WWW-Authenticate", wwwAuthenticate)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Transfer>(),
            PostTransfersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Approve initiated transfers
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="wwwAuthenticate">Header for authenticating through SCA</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="JsonElement"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTransfersApproveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates the approval of a list of transfers that triggered an additional <see href="https://docs.adyen.com/api-explorer/transfers/latest/post/transfers#request-review">review</see>. Adyen sends the outcome of the approval request through webhooks.
    /// <para>
    /// To use this endpoint:
    /// - Your API credential must have the <b>TransferService Approve</b> <see href="https://docs.adyen.com/platforms/manage-access/webservice-roles/?tab=transfers_3">role</see>.
    /// - The account holder must have the required <see href="https://docs.adyen.com/platforms/verification-overview/capabilities">capabilities</see>.
    /// </para>
    /// <para>
    /// Reach out to your Adyen contact to set up these permissions.
    /// </para>
    /// </remarks>
    public Task<JsonElement> PostTransfersApprove(string? idempotencyKey,
        string? wwwAuthenticate,
        ApproveTransfersRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/transfers/approve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey), new HeaderParam("WWW-Authenticate", wwwAuthenticate)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<JsonElement>(),
            PostTransfersApproveErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel initiated transfers
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="JsonElement"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTransfersCancelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates the cancellation of a list of transfers that triggered an additional <see href="https://docs.adyen.com/api-explorer/transfers/latest/post/transfers#request-review">review</see>. Adyen sends the outcome of the cancel request through webhooks.
    /// <para>
    /// To use this endpoint:
    /// - Your API credential must have the <b>TransferService Approve</b> <see href="https://docs.adyen.com/platforms/manage-access/webservice-roles/?tab=transfers_3">role</see>.
    /// - The account holder must have the required <see href="https://docs.adyen.com/platforms/verification-overview/capabilities">capabilities</see>.
    /// </para>
    /// <para>
    /// Reach out to your Adyen contact to set up these permissions.
    /// </para>
    /// </remarks>
    public Task<JsonElement> PostTransfersCancel(string? idempotencyKey,
        CancelTransfersRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/transfers/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<JsonElement>(),
            PostTransfersCancelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Return a transfer
    /// </summary>
    /// <param name="transferId">The unique identifier of the transfer to be returned.</param>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReturnTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTransfersTransferIdReturnsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates the return of previously transferred funds without creating a new <c>transferId</c>.
    /// </remarks>
    public Task<ReturnTransferResponse> PostTransfersTransferIdReturns(string transferId,
        string? idempotencyKey,
        ReturnTransferRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default14("/transfers/{transferId}/returns"),
            [new TemplateParam("transferId", transferId)],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ReturnTransferResponse>(),
            PostTransfersTransferIdReturnsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
