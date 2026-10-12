using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;
using Adyen.Requests.ManagedPayoutSchedules;

namespace Adyen.Api;

public sealed class ManagedPayoutSchedules
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ManagedPayoutSchedules(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Delete a managed payout schedule on a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a payout schedule applied to a balance account.
    /// </remarks>
    public Task DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesId(DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules/{id}"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId), new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all managed payout schedules on a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccountConfigurations"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsBalanceAccountIdPayoutSchedulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all managed payout schedules that are configured on a balance account. You can use query parameters to filter the elements that are returned in the list.
    /// </remarks>
    public Task<BalanceAccountConfigurations> GetBalanceAccountsBalanceAccountIdPayoutSchedules(GetBalanceAccountsBalanceAccountIdPayoutSchedulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId)],
            [
                new Param("currency", request.Currency),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalanceAccountConfigurations>(),
            GetBalanceAccountsBalanceAccountIdPayoutSchedulesError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a specific managed payout schedule on a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccountConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the specified payout schedule.
    /// </remarks>
    public Task<BalanceAccountConfiguration> GetBalanceAccountsBalanceAccountIdPayoutSchedulesId(GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules/{id}"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId), new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalanceAccountConfiguration>(),
            GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// View executions of a managed payout schedule
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutScheduleExecutions"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// View information about the executions of a managed payout schedule on the specified balance account. An execution is an attempt to make a payout according to the payout schedule.
    /// </remarks>
    public Task<PayoutScheduleExecutions> GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutions(GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules/{id}/executions"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId), new TemplateParam("id", request.Id)],
            [
                new Param("offset", request.Offset),
                new Param("results", request.Results),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PayoutScheduleExecutions>(),
            GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all managed payout schedules on your balance platform
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalancePlatformConfigurations"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalancePlatformsBalancePlatformIdPayoutSchedulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all the payout schedules that are configured for your balance platform. You can use query parameters to filter the elements that are returned in the list.
    /// </remarks>
    public Task<BalancePlatformConfigurations> GetBalancePlatformsBalancePlatformIdPayoutSchedules(GetBalancePlatformsBalancePlatformIdPayoutSchedulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{balancePlatformId}/payoutSchedules"),
            [new TemplateParam("balancePlatformId", request.BalancePlatformId)],
            [new Param("countryCode", request.CountryCode), new Param("currency", request.Currency)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalancePlatformConfigurations>(),
            GetBalancePlatformsBalancePlatformIdPayoutSchedulesError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a specific managed payout schedule on your balance platform
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalancePlatformConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the specified managed payout schedule configured on your balance platform.
    /// </remarks>
    public Task<BalancePlatformConfiguration> GetBalancePlatformsBalancePlatformIdPayoutSchedulesId(GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{balancePlatformId}/payoutSchedules/{id}"),
            [new TemplateParam("balancePlatformId", request.BalancePlatformId), new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalancePlatformConfiguration>(),
            GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a managed payout schedule on a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccountConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a managed payout schedule applied to a balance account. If an optional parameter is not included in the request, it remains unchanged.
    /// </remarks>
    public Task<BalanceAccountConfiguration> PatchBalanceAccountsBalanceAccountIdPayoutSchedulesId(PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules/{id}"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId), new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BalanceAccountConfiguration>(),
            PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Apply a managed payout schedule to a balance account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccountConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostBalanceAccountsBalanceAccountIdPayoutSchedulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Apply a managed payout schedule to a balance account. This payout schedule is based on an existing payout schedule in your balance platform.
    /// </remarks>
    public Task<BalanceAccountConfiguration> PostBalanceAccountsBalanceAccountIdPayoutSchedules(PostBalanceAccountsBalanceAccountIdPayoutSchedulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BalanceAccountConfiguration>(),
            PostBalanceAccountsBalanceAccountIdPayoutSchedulesError.Response,
            [],
            requestOptions,
            cancellationToken);
}
