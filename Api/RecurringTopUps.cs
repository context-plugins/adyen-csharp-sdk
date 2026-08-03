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

namespace Adyen.Api;

public sealed class RecurringTopUps
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal RecurringTopUps(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// delete-balanceAccounts-balanceAccountId-recurringTopUps-topUpId
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="topUpId">The unique identifier of the recurring top-up you want to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a recurring top up configuration by <c>topUpId</c>.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups">Manage recurring top-ups</see>.
    /// </para>
    /// </remarks>
    public Task<object> DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(string balanceAccountId,
        string topUpId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{balanceAccountId}/recurringTopUps/{topUpId}"),
            [new TemplateParam("balanceAccountId", balanceAccountId), new TemplateParam("topUpId", topUpId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// get-balanceAccounts-balanceAccountId-recurringTopUps
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="cursor">The cursor used for pagination. Required if you want to see the next or previous page of results.</param>
    /// <param name="limit">The number of items to return per page. Value must be between 1 and 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringTopUpsResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsBalanceAccountIdRecurringTopUpsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// View all recurring top ups configured for a specific <c>balanceAccountId</c>.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups">Manage recurring top-ups</see>.
    /// </para>
    /// </remarks>
    public Task<RecurringTopUpsResult> GetBalanceAccountsBalanceAccountIdRecurringTopUps(string balanceAccountId,
        string? cursor,
        int? limit = 10,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{balanceAccountId}/recurringTopUps"),
            [new TemplateParam("balanceAccountId", balanceAccountId)],
            [new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RecurringTopUpsResult>(),
            GetBalanceAccountsBalanceAccountIdRecurringTopUpsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// patch-balanceAccounts-balanceAccountId-recurringTopUps-topUpId
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="topUpId">The unique identifier of the recurring top-up you want to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringTopUp"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the configuration of an existing recurring top up.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups">Manage recurring top-ups</see>.
    /// </para>
    /// </remarks>
    public Task<RecurringTopUp> PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(string balanceAccountId,
        string topUpId,
        PatchableCreateRecurringTopUp body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{balanceAccountId}/recurringTopUps/{topUpId}"),
            [new TemplateParam("balanceAccountId", balanceAccountId), new TemplateParam("topUpId", topUpId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringTopUp>(),
            PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// post-balanceAccounts-balanceAccountId-recurringTopUps
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringTopUp"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostBalanceAccountsBalanceAccountIdRecurringTopUpsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a recurring top up configuration.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/issuing/add-manage-funds/top-ups/create-recurring-top-ups">Create recurring top-ups</see>.
    /// </para>
    /// </remarks>
    public Task<RecurringTopUp> PostBalanceAccountsBalanceAccountIdRecurringTopUps(string balanceAccountId,
        CreateRecurringTopUp body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceAccounts/{balanceAccountId}/recurringTopUps"),
            [new TemplateParam("balanceAccountId", balanceAccountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringTopUp>(),
            PostBalanceAccountsBalanceAccountIdRecurringTopUpsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
