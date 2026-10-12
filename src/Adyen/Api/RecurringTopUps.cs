using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;
using Adyen.Requests.RecurringTopUps;

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
    /// Delete a recurring top up
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="JsonElement"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a recurring top up configuration by <c>topUpId</c>.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups">Manage recurring top-ups</see>.
    /// </para>
    /// </remarks>
    public Task<JsonElement> DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/recurringTopUps/{topUpId}"),
            [
                new TemplateParam("balanceAccountId", request.BalanceAccountId),
                new TemplateParam("topUpId", request.TopUpId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<JsonElement>(),
            DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get recurring top ups for a specific balanceAccountId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringTopUpsResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsBalanceAccountIdRecurringTopUpsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// View all recurring top ups configured for a specific <c>balanceAccountId</c>.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups">Manage recurring top-ups</see>.
    /// </para>
    /// </remarks>
    public Task<RecurringTopUpsResult> GetBalanceAccountsBalanceAccountIdRecurringTopUps(GetBalanceAccountsBalanceAccountIdRecurringTopUpsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/recurringTopUps"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId)],
            [new Param("limit", request.Limit), new Param("cursor", request.Cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RecurringTopUpsResult>(),
            GetBalanceAccountsBalanceAccountIdRecurringTopUpsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a RecurringTopUp
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringTopUp"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the configuration of an existing recurring top up.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups">Manage recurring top-ups</see>.
    /// </para>
    /// </remarks>
    public Task<RecurringTopUp> PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/recurringTopUps/{topUpId}"),
            [
                new TemplateParam("balanceAccountId", request.BalanceAccountId),
                new TemplateParam("topUpId", request.TopUpId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RecurringTopUp>(),
            PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create recurring top up
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringTopUp"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostBalanceAccountsBalanceAccountIdRecurringTopUpsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a recurring top up configuration.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/issuing/add-manage-funds/top-ups/create-recurring-top-ups">Create recurring top-ups</see>.
    /// </para>
    /// </remarks>
    public Task<RecurringTopUp> PostBalanceAccountsBalanceAccountIdRecurringTopUps(PostBalanceAccountsBalanceAccountIdRecurringTopUpsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{balanceAccountId}/recurringTopUps"),
            [new TemplateParam("balanceAccountId", request.BalanceAccountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RecurringTopUp>(),
            PostBalanceAccountsBalanceAccountIdRecurringTopUpsError.Response,
            [],
            requestOptions,
            cancellationToken);
}
