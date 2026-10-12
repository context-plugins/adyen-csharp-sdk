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
using Adyen.Requests.BalanceAccounts;

namespace Adyen.Api;

public sealed class BalanceAccounts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal BalanceAccounts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccount"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a balance account and its balances for the default currency and other currencies with a non-zero balance.
    /// </remarks>
    public Task<BalanceAccount> GetBalanceAccountsId(GetBalanceAccountsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalanceAccount>(),
            GetBalanceAccountsIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get payment instruments linked to a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedPaymentInstrumentsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsIdPaymentInstrumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of the payment instruments associated with a balance account.
    /// <para>
    /// To fetch multiple pages, use the query parameters.For example, to limit the page to 3 payment instruments which are in active status and to skip the first 6, use <c>/balanceAccounts/{id}/paymentInstruments?limit=3&amp;offset=6&amp;status=active</c>.
    /// </para>
    /// </remarks>
    public Task<PaginatedPaymentInstrumentsResponse> GetBalanceAccountsIdPaymentInstruments(GetBalanceAccountsIdPaymentInstrumentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}/paymentInstruments"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("offset", request.Offset),
                new Param("limit", request.Limit),
                new Param("status", request.Status),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedPaymentInstrumentsResponse>(),
            GetBalanceAccountsIdPaymentInstrumentsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all transaction rules for a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRulesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsIdTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of transaction rules associated with a balance account.
    /// </remarks>
    public Task<TransactionRulesResponse> GetBalanceAccountsIdTransactionRules(GetBalanceAccountsIdTransactionRulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}/transactionRules"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRulesResponse>(),
            GetBalanceAccountsIdTransactionRulesError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccount"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchBalanceAccountsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a balance account.
    /// </remarks>
    public Task<BalanceAccount> PatchBalanceAccountsId(PatchBalanceAccountsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BalanceAccount>(),
            PatchBalanceAccountsIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccount"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostBalanceAccountsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a balance account that holds the funds of the associated account holder.
    /// </remarks>
    public Task<BalanceAccount> PostBalanceAccounts(PostBalanceAccountsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BalanceAccount>(),
            PostBalanceAccountsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
