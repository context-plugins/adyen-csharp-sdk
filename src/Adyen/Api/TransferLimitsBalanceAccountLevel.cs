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
using Adyen.Requests.TransferLimitsBalanceAccountLevel;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a scheduled or pending transfer limit using its unique <c>transferLimitId</c>. You cannot delete an active limit.
    /// </remarks>
    public Task DeleteBalanceAccountsIdTransferLimitsTransferLimitId(DeleteBalanceAccountsIdTransferLimitsTransferLimitIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}/transferLimits/{transferLimitId}"),
            [new TemplateParam("id", request.Id), new TemplateParam("transferLimitId", request.TransferLimitId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Filter and view the transfer limits
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLimitListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsIdTransferLimitsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Filter and view the transfer limits configured for a balance account using the balance account's unique <c>id</c> and the available query parameters.
    /// </remarks>
    public Task<TransferLimitListResponse> GetBalanceAccountsIdTransferLimits(GetBalanceAccountsIdTransferLimitsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}/transferLimits"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("scope", request.Scope),
                new Param("transferType", request.TransferType),
                new Param("status", request.Status),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransferLimitListResponse>(),
            GetBalanceAccountsIdTransferLimitsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all current transfer limits
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLimitListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsIdTransferLimitsCurrentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all transfer limits that currently apply to a balance account using the unique <c>id</c> of the balance account.
    /// </remarks>
    public Task<TransferLimitListResponse> GetBalanceAccountsIdTransferLimitsCurrent(GetBalanceAccountsIdTransferLimitsCurrentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}/transferLimits/current"),
            [new TemplateParam("id", request.Id)],
            [new Param("scope", request.Scope), new Param("transferType", request.TransferType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransferLimitListResponse>(),
            GetBalanceAccountsIdTransferLimitsCurrentError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the details of a transfer limit
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLimit"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalanceAccountsIdTransferLimitsTransferLimitIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the details of a transfer limit using its unique <c>transferLimitId</c>.
    /// </remarks>
    public Task<TransferLimit> GetBalanceAccountsIdTransferLimitsTransferLimitId(GetBalanceAccountsIdTransferLimitsTransferLimitIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}/transferLimits/{transferLimitId}"),
            [new TemplateParam("id", request.Id), new TemplateParam("transferLimitId", request.TransferLimitId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransferLimit>(),
            GetBalanceAccountsIdTransferLimitsTransferLimitIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a transfer limit
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLimit"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostBalanceAccountsIdTransferLimitsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a transfer limit for your balance account using the unique <c>id</c> of your balance account.
    /// </remarks>
    public Task<TransferLimit> PostBalanceAccountsIdTransferLimits(PostBalanceAccountsIdTransferLimitsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}/transferLimits"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("WWW-Authenticate", request.WwwAuthenticate),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferLimit>(),
            PostBalanceAccountsIdTransferLimitsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Approve pending transfer limits
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostBalanceAccountsIdTransferLimitsApproveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Approve transfer limits that are pending SCA authentication.
    /// </remarks>
    public Task PostBalanceAccountsIdTransferLimitsApprove(PostBalanceAccountsIdTransferLimitsApproveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balanceAccounts/{id}/transferLimits/approve"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("WWW-Authenticate", request.WwwAuthenticate),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            PostBalanceAccountsIdTransferLimitsApproveError.Response,
            [],
            requestOptions,
            cancellationToken);
}
