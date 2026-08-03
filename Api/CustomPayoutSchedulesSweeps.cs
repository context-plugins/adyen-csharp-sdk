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

public sealed class CustomPayoutSchedulesSweeps
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CustomPayoutSchedulesSweeps(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// delete-balanceAccounts-balanceAccountId-sweeps-sweepId
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="sweepId">The unique identifier of the sweep.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a sweep for a balance account.
    /// </remarks>
    public Task DeleteBalanceAccountsBalanceAccountIdSweepsSweepId(string balanceAccountId,
        string sweepId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}"),
            [new TemplateParam("balanceAccountId", balanceAccountId), new TemplateParam("sweepId", sweepId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-balanceAccounts-balanceAccountId-sweeps
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="offset">The number of items that you want to skip.</param>
    /// <param name="limit">The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceSweepConfigurationsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsBalanceAccountIdSweepsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of the sweeps configured for a balance account.
    /// <para>
    /// To fetch multiple pages, use the query parameters. For example, to limit the page to 5 sweeps and to skip the first 10, use <c>/balanceAccounts/{balanceAccountId}/sweeps?limit=5&amp;offset=10</c>.
    /// </para>
    /// </remarks>
    public Task<BalanceSweepConfigurationsResponse> GetBalanceAccountsBalanceAccountIdSweeps(string balanceAccountId,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{balanceAccountId}/sweeps"),
            [new TemplateParam("balanceAccountId", balanceAccountId)],
            [new Param("offset", offset), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalanceSweepConfigurationsResponse>(),
            GetBalanceAccountsBalanceAccountIdSweepsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-balanceAccounts-balanceAccountId-sweeps-sweepId
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="sweepId">The unique identifier of the sweep.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SweepConfigurationV2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsBalanceAccountIdSweepsSweepIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a sweep.
    /// </remarks>
    public Task<SweepConfigurationV2> GetBalanceAccountsBalanceAccountIdSweepsSweepId(string balanceAccountId,
        string sweepId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}"),
            [new TemplateParam("balanceAccountId", balanceAccountId), new TemplateParam("sweepId", sweepId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SweepConfigurationV2>(),
            GetBalanceAccountsBalanceAccountIdSweepsSweepIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-balanceAccounts-balanceAccountId-sweeps-sweepId
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="sweepId">The unique identifier of the sweep.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SweepConfigurationV2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a sweep. When updating a sweep resource, note that if a request parameter is not provided, the parameter is left unchanged.
    /// </remarks>
    public Task<SweepConfigurationV2> PatchBalanceAccountsBalanceAccountIdSweepsSweepId(string balanceAccountId,
        string sweepId,
        UpdateSweepConfigurationV2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}"),
            [new TemplateParam("balanceAccountId", balanceAccountId), new TemplateParam("sweepId", sweepId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<SweepConfigurationV2>(),
            PatchBalanceAccountsBalanceAccountIdSweepsSweepIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-balanceAccounts-balanceAccountId-sweeps
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SweepConfigurationV2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostBalanceAccountsBalanceAccountIdSweepsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a sweep that results in moving funds from or to a balance account.
    /// <para>
    /// A sweep pulls in or pushes out funds based on a defined schedule, amount, currency, and a source or a destination.
    /// </para>
    /// </remarks>
    public Task<SweepConfigurationV2> PostBalanceAccountsBalanceAccountIdSweeps(string balanceAccountId,
        CreateSweepConfigurationV2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{balanceAccountId}/sweeps"),
            [new TemplateParam("balanceAccountId", balanceAccountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SweepConfigurationV2>(),
            PostBalanceAccountsBalanceAccountIdSweepsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
