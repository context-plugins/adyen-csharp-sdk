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
    /// get-balanceAccounts-id
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccount"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a balance account and its balances for the default currency and other currencies with a non-zero balance.
    /// </remarks>
    public Task<BalanceAccount> GetBalanceAccountsId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalanceAccount>(),
            GetBalanceAccountsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-balanceAccounts-id-paymentInstruments
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="offset">The number of items that you want to skip.</param>
    /// <param name="limit">The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
    /// <param name="status">The status of the payment instruments that you want to get. By default, the response includes payment instruments with any status.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedPaymentInstrumentsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsIdPaymentInstrumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of the payment instruments associated with a balance account.
    /// <para>
    /// To fetch multiple pages, use the query parameters.For example, to limit the page to 3 payment instruments which are in active status and to skip the first 6, use <c>/balanceAccounts/{id}/paymentInstruments?limit=3&amp;offset=6&amp;status=active</c>.
    /// </para>
    /// </remarks>
    public Task<PaginatedPaymentInstrumentsResponse> GetBalanceAccountsIdPaymentInstruments(string id,
        int? offset,
        int? limit,
        string? status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{id}/paymentInstruments"),
            [new TemplateParam("id", id)],
            [new Param("offset", offset), new Param("limit", limit), new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedPaymentInstrumentsResponse>(),
            GetBalanceAccountsIdPaymentInstrumentsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-balanceAccounts-id-transactionRules
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRulesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsIdTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of transaction rules associated with a balance account.
    /// </remarks>
    public Task<TransactionRulesResponse> GetBalanceAccountsIdTransactionRules(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{id}/transactionRules"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRulesResponse>(),
            GetBalanceAccountsIdTransactionRulesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-balanceAccounts-id
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccount"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchBalanceAccountsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a balance account.
    /// </remarks>
    public Task<BalanceAccount> PatchBalanceAccountsId(string id,
        BalanceAccountUpdateRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<BalanceAccount>(),
            PatchBalanceAccountsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-balanceAccounts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccount"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostBalanceAccountsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a balance account that holds the funds of the associated account holder.
    /// </remarks>
    public Task<BalanceAccount> PostBalanceAccounts(BalanceAccountInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BalanceAccount>(),
            PostBalanceAccountsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
