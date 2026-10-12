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
using Adyen.Requests.CustomPayoutSchedulesSweeps;

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
    /// Delete a sweep
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a sweep for a balance account.
    /// </remarks>
    public Task DeleteBalanceAccountsBalanceAccountIdSweepsSweepId(DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}"),
            [
                new TemplateParam("balanceAccountId", request.BalanceAccountId),
                new TemplateParam("sweepId", request.SweepId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all sweeps for a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceSweepConfigurationsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsBalanceAccountIdSweepsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of the sweeps configured for a balance account.
    /// <para>
    /// To fetch multiple pages, use the query parameters. For example, to limit the page to 5 sweeps and to skip the first 10, use <c>/balanceAccounts/{balanceAccountId}/sweeps?limit=5&amp;offset=10</c>.
    /// </para>
    /// </remarks>
    public Task<BalanceSweepConfigurationsResponse> GetBalanceAccountsBalanceAccountIdSweeps(GetBalanceAccountsBalanceAccountIdSweepsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/sweeps"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId)],
            [new Param("offset", request.Offset), new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalanceSweepConfigurationsResponse>(),
            GetBalanceAccountsBalanceAccountIdSweepsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a sweep
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SweepConfigurationV2"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsBalanceAccountIdSweepsSweepIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a sweep.
    /// </remarks>
    public Task<SweepConfigurationV2> GetBalanceAccountsBalanceAccountIdSweepsSweepId(GetBalanceAccountsBalanceAccountIdSweepsSweepIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}"),
            [
                new TemplateParam("balanceAccountId", request.BalanceAccountId),
                new TemplateParam("sweepId", request.SweepId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SweepConfigurationV2>(),
            GetBalanceAccountsBalanceAccountIdSweepsSweepIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a sweep
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SweepConfigurationV2"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a sweep. When updating a sweep resource, note that if a request parameter is not provided, the parameter is left unchanged.
    /// </remarks>
    public Task<SweepConfigurationV2> PatchBalanceAccountsBalanceAccountIdSweepsSweepId(PatchBalanceAccountsBalanceAccountIdSweepsSweepIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/sweeps/{sweepId}"),
            [
                new TemplateParam("balanceAccountId", request.BalanceAccountId),
                new TemplateParam("sweepId", request.SweepId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SweepConfigurationV2>(),
            PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a sweep
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SweepConfigurationV2"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostBalanceAccountsBalanceAccountIdSweepsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a sweep that results in moving funds from or to a balance account.
    /// <para>
    /// A sweep pulls in or pushes out funds based on a defined schedule, amount, currency, and a source or a destination.
    /// </para>
    /// </remarks>
    public Task<SweepConfigurationV2> PostBalanceAccountsBalanceAccountIdSweeps(PostBalanceAccountsBalanceAccountIdSweepsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/sweeps"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SweepConfigurationV2>(),
            PostBalanceAccountsBalanceAccountIdSweepsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
