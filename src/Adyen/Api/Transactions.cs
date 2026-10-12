using System.Net.Http;
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
using Adyen.Requests.Transactions;

namespace Adyen.Api;

public sealed class Transactions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Transactions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get all transactions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionSearchResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTransactionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// &gt;Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.
    /// <para>
    /// Returns all the transactions related to a balance account, account holder, or balance platform.
    /// </para>
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
    public Task<TransactionSearchResponse> GetTransactions(GetTransactionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default14("/transactions"),
            [],
            [
                new Param("createdSince", request.CreatedSince.ToIso8601()),
                new Param("createdUntil", request.CreatedUntil.ToIso8601()),
                new Param("balancePlatform", request.BalancePlatform),
                new Param("paymentInstrumentId", request.PaymentInstrumentId),
                new Param("accountHolderId", request.AccountHolderId),
                new Param("balanceAccountId", request.BalanceAccountId),
                new Param("cursor", request.Cursor),
                new Param("sortOrder", request.SortOrder),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionSearchResponse>(),
            GetTransactionsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a transaction
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Transaction"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTransactionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// &gt;Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.
    /// <para>
    /// Returns a transaction.
    /// </para>
    /// </remarks>
    public Task<Transaction> GetTransactionsId(GetTransactionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default14("/transactions/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Transaction>(),
            GetTransactionsIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
