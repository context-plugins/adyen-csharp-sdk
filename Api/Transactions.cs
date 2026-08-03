using System;
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
using Adyen.Models.Enums;

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
    /// get-transactions
    /// </summary>
    /// <param name="createdSince">Only include transactions that have been created on or after this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.</param>
    /// <param name="createdUntil">Only include transactions that have been created on or before this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.</param>
    /// <param name="balancePlatform">The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id">balance platform</see>.  Required if you don't provide a <c>balanceAccountId</c> or <c>accountHolderId</c>.</param>
    /// <param name="paymentInstrumentId">The unique identifier of the <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_">payment instrument</see>.  To use this parameter, you must also provide a <c>balanceAccountId</c>, <c>accountHolderId</c>, or <c>balancePlatform</c>.  The <c>paymentInstrumentId</c> must be related to the <c>balanceAccountId</c> or <c>accountHolderId</c> that you provide.</param>
    /// <param name="accountHolderId">The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id">account holder</see>.  Required if you don't provide a <c>balanceAccountId</c> or <c>balancePlatform</c>.  If you provide a <c>balanceAccountId</c>, the <c>accountHolderId</c> must be related to the <c>balanceAccountId</c>.</param>
    /// <param name="balanceAccountId">The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id">balance account</see>.  Required if you don't provide an <c>accountHolderId</c> or <c>balancePlatform</c>.  If you provide an <c>accountHolderId</c>, the <c>balanceAccountId</c> must be related to the <c>accountHolderId</c>.</param>
    /// <param name="cursor">The <c>cursor</c> returned in the links of the previous response.</param>
    /// <param name="sortOrder">Determines the sort order of the returned transactions. The sort order is based on the creation date of the transaction.  Possible values:   - <b>asc</b>: Ascending order, from oldest to most recent.  - <b>desc</b>: Descending order, from most recent to oldest.  Default value: <b>asc</b>.</param>
    /// <param name="limit">The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionSearchResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTransactionsError"/> when the server returns an error response.</exception>
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
    public Task<TransactionSearchResponse> GetTransactions(DateTimeOffset createdSince,
        DateTimeOffset createdUntil,
        string? balancePlatform,
        string? paymentInstrumentId,
        string? accountHolderId,
        string? balanceAccountId,
        string? cursor,
        SortOrder2? sortOrder,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactions"),
            [],
            [new Param("createdSince", createdSince.ToIso8601()),
                new Param("createdUntil", createdUntil.ToIso8601()),
                new Param("balancePlatform", balancePlatform),
                new Param("paymentInstrumentId", paymentInstrumentId),
                new Param("accountHolderId", accountHolderId),
                new Param("balanceAccountId", balanceAccountId),
                new Param("cursor", cursor),
                new Param("sortOrder", sortOrder),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionSearchResponse>(),
            GetTransactionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-transactions-id
    /// </summary>
    /// <param name="id">The unique identifier of the transaction.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Transaction1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTransactionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// &gt;Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.
    /// <para>
    /// Returns a transaction.
    /// </para>
    /// </remarks>
    public Task<Transaction1> GetTransactionsId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactions/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Transaction1>(),
            GetTransactionsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
