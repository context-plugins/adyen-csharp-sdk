using System;
using System.Collections.Generic;
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
using Adyen.Models.Enums;

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
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="id">The unique identifier of the payout schedule applied to the balance account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a payout schedule applied to a balance account.
    /// </remarks>
    public Task DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesId(string balanceAccountId,
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules/{id}"),
            [new TemplateParam("balanceAccountId", balanceAccountId), new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get all managed payout schedules on a balance account
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="currency">The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> of the currency used in the payout schedule.</param>
    /// <param name="cursor">The <c>cursor</c> returned in the links of the previous response.</param>
    /// <param name="limit">The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccountConfigurations"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsBalanceAccountIdPayoutSchedulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all managed payout schedules that are configured on a balance account. You can use query parameters to filter the elements that are returned in the list.
    /// </remarks>
    public Task<BalanceAccountConfigurations> GetBalanceAccountsBalanceAccountIdPayoutSchedules(string balanceAccountId,
        string? currency,
        string? cursor,
        int? limit = 10,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules"),
            [new TemplateParam("balanceAccountId", balanceAccountId)],
            [new Param("currency", currency), new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalanceAccountConfigurations>(),
            GetBalanceAccountsBalanceAccountIdPayoutSchedulesErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific managed payout schedule on a balance account
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="id">The unique identifier of the payout schedule for the balance account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccountConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the specified payout schedule.
    /// </remarks>
    public Task<BalanceAccountConfiguration> GetBalanceAccountsBalanceAccountIdPayoutSchedulesId(string balanceAccountId,
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules/{id}"),
            [new TemplateParam("balanceAccountId", balanceAccountId), new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalanceAccountConfiguration>(),
            GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// View executions of a managed payout schedule
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="id">The unique identifier of the payout schedule on the balance account.</param>
    /// <param name="offset">The page number to be returned.  Default: <b>1</b></param>
    /// <param name="results">Contains a list of payout statuses. If included, the response returns only executed payouts that currently have one of the specified statuses.  Possible statuses: - <b>succeeded</b>: The payout was sent successfully. - <b>failed</b>: The payout was not sent due to an error. - <b>skipped</b>: The payout was not triggered as expected.</param>
    /// <param name="limit">The number of items returned per page.  Default: <b>10</b></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutScheduleExecutions"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// View information about the executions of a managed payout schedule on the specified balance account. An execution is an attempt to make a payout according to the payout schedule.
    /// </remarks>
    public Task<PayoutScheduleExecutions> GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutions(string balanceAccountId,
        string id,
        int offset,
        IReadOnlyList<ExecutionResult>? results,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules/{id}/executions"),
            [new TemplateParam("balanceAccountId", balanceAccountId), new TemplateParam("id", id)],
            [new Param("offset", offset), new Param("results", results), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PayoutScheduleExecutions>(),
            GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get all managed payout schedules on your balance platform
    /// </summary>
    /// <param name="balancePlatformId">The unique identifier of the balance platform.</param>
    /// <param name="countryCode">The two-letter <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code of the country to which the payout configuration applies.</param>
    /// <param name="currency">The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> of the currency used in the payout configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalancePlatformConfigurations"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalancePlatformsBalancePlatformIdPayoutSchedulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all the payout schedules that are configured for your balance platform. You can use query parameters to filter the elements that are returned in the list.
    /// </remarks>
    public Task<BalancePlatformConfigurations> GetBalancePlatformsBalancePlatformIdPayoutSchedules(string balancePlatformId,
        string? countryCode,
        string? currency,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balancePlatforms/{balancePlatformId}/payoutSchedules"),
            [new TemplateParam("balancePlatformId", balancePlatformId)],
            [new Param("countryCode", countryCode), new Param("currency", currency)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalancePlatformConfigurations>(),
            GetBalancePlatformsBalancePlatformIdPayoutSchedulesErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific managed payout schedule on your balance platform
    /// </summary>
    /// <param name="balancePlatformId">The unique identifier of the balance platform.</param>
    /// <param name="id">The unique identifier of the payout configuration for your balance platform.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalancePlatformConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the specified managed payout schedule configured on your balance platform.
    /// </remarks>
    public Task<BalancePlatformConfiguration> GetBalancePlatformsBalancePlatformIdPayoutSchedulesId(string balancePlatformId,
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balancePlatforms/{balancePlatformId}/payoutSchedules/{id}"),
            [new TemplateParam("balancePlatformId", balancePlatformId), new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BalancePlatformConfiguration>(),
            GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update a managed payout schedule on a balance account
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="id">The unique identifier of the payout schedule applied to the balance account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccountConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a managed payout schedule applied to a balance account. If an optional parameter is not included in the request, it remains unchanged.
    /// </remarks>
    public Task<BalanceAccountConfiguration> PatchBalanceAccountsBalanceAccountIdPayoutSchedulesId(string balanceAccountId,
        string id,
        BalanceAccountConfigurationUpdate body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules/{id}"),
            [new TemplateParam("balanceAccountId", balanceAccountId), new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<BalanceAccountConfiguration>(),
            PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Apply a managed payout schedule to a balance account
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceAccountConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostBalanceAccountsBalanceAccountIdPayoutSchedulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Apply a managed payout schedule to a balance account. This payout schedule is based on an existing payout schedule in your balance platform.
    /// </remarks>
    public Task<BalanceAccountConfiguration> PostBalanceAccountsBalanceAccountIdPayoutSchedules(string balanceAccountId,
        BalanceAccountConfigurationRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{balanceAccountId}/payoutSchedules"),
            [new TemplateParam("balanceAccountId", balanceAccountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BalanceAccountConfiguration>(),
            PostBalanceAccountsBalanceAccountIdPayoutSchedulesErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
