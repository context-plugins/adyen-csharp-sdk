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
using Adyen.Requests.Transfers;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FindTransfersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTransfersError"/> when the server returns an error response.</exception>
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
    public Task<FindTransfersResponse> GetTransfers(GetTransfersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default14("/transfers"),
            [],
            [
                new Param("createdSince", request.CreatedSince.ToIso8601()),
                new Param("createdUntil", request.CreatedUntil.ToIso8601()),
                new Param("balancePlatform", request.BalancePlatform),
                new Param("accountHolderId", request.AccountHolderId),
                new Param("balanceAccountId", request.BalanceAccountId),
                new Param("paymentInstrumentId", request.PaymentInstrumentId),
                new Param("reference", request.Reference),
                new Param("category", request.Category),
                new Param("sortOrder", request.SortOrder),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FindTransfersResponse>(),
            GetTransfersError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a transfer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferData"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTransfersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a specified transfer.
    /// </remarks>
    public Task<TransferData> GetTransfersId(GetTransfersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default14("/transfers/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransferData>(),
            GetTransfersIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Transfer funds
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Transfer"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTransfersError"/> when the server returns an error response.</exception>
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
    public Task<Transfer> PostTransfers(PostTransfersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default14("/transfers"),
            [],
            [],
            [
                new HeaderParam("Idempotency-Key", request.IdempotencyKey),
                new HeaderParam("WWW-Authenticate", request.WwwAuthenticate),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Transfer>(),
            PostTransfersError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Approve initiated transfers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="JsonElement"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTransfersApproveError"/> when the server returns an error response.</exception>
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
    public Task<JsonElement> PostTransfersApprove(PostTransfersApproveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default14("/transfers/approve"),
            [],
            [],
            [
                new HeaderParam("Idempotency-Key", request.IdempotencyKey),
                new HeaderParam("WWW-Authenticate", request.WwwAuthenticate),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<JsonElement>(),
            PostTransfersApproveError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel initiated transfers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="JsonElement"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTransfersCancelError"/> when the server returns an error response.</exception>
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
    public Task<JsonElement> PostTransfersCancel(PostTransfersCancelRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default14("/transfers/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<JsonElement>(),
            PostTransfersCancelError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Return a transfer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReturnTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTransfersTransferIdReturnsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates the return of previously transferred funds without creating a new <c>transferId</c>.
    /// </remarks>
    public Task<ReturnTransferResponse> PostTransfersTransferIdReturns(PostTransfersTransferIdReturnsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default14("/transfers/{transferId}/returns"),
            [new TemplateParam("transferId", request.TransferId)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ReturnTransferResponse>(),
            PostTransfersTransferIdReturnsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
