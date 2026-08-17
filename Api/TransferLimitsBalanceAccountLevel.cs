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
using Adyen.Models.Enums;

namespace Adyen.Api;

public sealed class TransferLimitsBalanceAccountLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal TransferLimitsBalanceAccountLevel(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Delete a scheduled or pending transfer limit
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="transferLimitId">The unique identifier of the transfer limit.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a scheduled or pending transfer limit using its unique <c>transferLimitId</c>. You cannot delete an active limit.
    /// </remarks>
    public Task DeleteBalanceAccountsIdTransferLimitsTransferLimitId(string id,
        string transferLimitId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{id}/transferLimits/{transferLimitId}"),
            [new TemplateParam("id", id), new TemplateParam("transferLimitId", transferLimitId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteBalanceAccountsIdTransferLimitsTransferLimitIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Filter and view the transfer limits
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="scope">The scope to which the transfer limit applies. Possible values: * <b>perTransaction</b>: you set a maximum amount for each transfer made from the balance account or balance platform. * <b>perDay</b>: you set a maximum total amount for all transfers made from the balance account or balance platform in a day.</param>
    /// <param name="transferType">The type of transfer to which the limit applies. Possible values: * <b>instant</b>: the limit applies to transfers with an <b>instant</b> priority. * <b>all</b>: the limit applies to all transfers, regardless of priority.</param>
    /// <param name="status">The status of the transfer limit. Possible values:    * <b>active</b>: the limit is currently active. * <b>inactive</b>: the limit is currently inactive. * <b>pendingSCA</b>: the limit is pending until your user performs SCA. * <b>scheduled</b>: the limit is scheduled to become active at a future date.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLimitListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsIdTransferLimitsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Filter and view the transfer limits configured for a balance account using the balance account's unique <c>id</c> and the available query parameters.
    /// </remarks>
    public Task<TransferLimitListResponse> GetBalanceAccountsIdTransferLimits(string id,
        Scope? scope,
        TransferType? transferType,
        LimitStatus? status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{id}/transferLimits"),
            [new TemplateParam("id", id)],
            [new Param("scope", scope), new Param("transferType", transferType), new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransferLimitListResponse>(),
            GetBalanceAccountsIdTransferLimitsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get all current transfer limits
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="scope">The scope to which the transfer limit applies. Possible values: * <b>perTransaction</b>: you set a maximum amount for each transfer made from the balance account or balance platform. * <b>perDay</b>: you set a maximum total amount for all transfers made from the balance account or balance platform in a day.</param>
    /// <param name="transferType">The type of transfer to which the limit applies. Possible values: * <b>instant</b>: the limit applies to transfers with an <b>instant</b> priority. * <b>all</b>: the limit applies to all transfers, regardless of priority.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLimitListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsIdTransferLimitsCurrentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all transfer limits that currently apply to a balance account using the unique <c>id</c> of the balance account.
    /// </remarks>
    public Task<TransferLimitListResponse> GetBalanceAccountsIdTransferLimitsCurrent(string id,
        Scope? scope,
        TransferType? transferType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{id}/transferLimits/current"),
            [new TemplateParam("id", id)],
            [new Param("scope", scope), new Param("transferType", transferType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransferLimitListResponse>(),
            GetBalanceAccountsIdTransferLimitsCurrentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get the details of a transfer limit
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="transferLimitId">The unique identifier of the transfer limit.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLimit"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalanceAccountsIdTransferLimitsTransferLimitIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the details of a transfer limit using its unique <c>transferLimitId</c>.
    /// </remarks>
    public Task<TransferLimit> GetBalanceAccountsIdTransferLimitsTransferLimitId(string id,
        string transferLimitId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{id}/transferLimits/{transferLimitId}"),
            [new TemplateParam("id", id), new TemplateParam("transferLimitId", transferLimitId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransferLimit>(),
            GetBalanceAccountsIdTransferLimitsTransferLimitIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create a transfer limit
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="wwwAuthenticate">Header for authenticating through SCA</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLimit"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostBalanceAccountsIdTransferLimitsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a transfer limit for your balance account using the unique <c>id</c> of your balance account.
    /// </remarks>
    public Task<TransferLimit> PostBalanceAccountsIdTransferLimits(string id,
        string? wwwAuthenticate,
        CreateTransferLimitRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{id}/transferLimits"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("WWW-Authenticate", wwwAuthenticate),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferLimit>(),
            PostBalanceAccountsIdTransferLimitsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Approve pending transfer limits
    /// </summary>
    /// <param name="id">The unique identifier of the balance account.</param>
    /// <param name="wwwAuthenticate">Header for authenticating using SCA.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostBalanceAccountsIdTransferLimitsApproveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Approve transfer limits that are pending SCA authentication.
    /// </remarks>
    public Task PostBalanceAccountsIdTransferLimitsApprove(string id,
        string? wwwAuthenticate,
        ApproveTransferLimitRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/balanceAccounts/{id}/transferLimits/approve"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("WWW-Authenticate", wwwAuthenticate),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            PostBalanceAccountsIdTransferLimitsApproveErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
