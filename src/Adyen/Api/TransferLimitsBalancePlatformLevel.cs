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
using Adyen.Requests.TransferLimitsBalancePlatformLevel;

namespace Adyen.Api;

public sealed class TransferLimitsBalancePlatformLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal TransferLimitsBalancePlatformLevel(RawClient rawClient, Server server)
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
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a scheduled or pending transfer limit using its unique <c>transferLimitId</c>. You cannot delete an active limit.
    /// </remarks>
    public Task DeleteBalancePlatformsIdTransferLimitsTransferLimitId(DeleteBalancePlatformsIdTransferLimitsTransferLimitIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{id}/transferLimits/{transferLimitId}"),
            [new TemplateParam("id", request.Id), new TemplateParam("transferLimitId", request.TransferLimitId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError.Response,
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
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalancePlatformsIdTransferLimitsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Filter and view the transfer limits configured for your balance platform using the balance platform's unique <c>id</c> and the available query parameters.
    /// </remarks>
    public Task<TransferLimitListResponse> GetBalancePlatformsIdTransferLimits(GetBalancePlatformsIdTransferLimitsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{id}/transferLimits"),
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
            GetBalancePlatformsIdTransferLimitsError.Response,
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
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalancePlatformsIdTransferLimitsTransferLimitIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the details of a transfer limit using its unique <c>transferLimitId</c>.
    /// </remarks>
    public Task<TransferLimit> GetBalancePlatformsIdTransferLimitsTransferLimitId(GetBalancePlatformsIdTransferLimitsTransferLimitIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{id}/transferLimits/{transferLimitId}"),
            [new TemplateParam("id", request.Id), new TemplateParam("transferLimitId", request.TransferLimitId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransferLimit>(),
            GetBalancePlatformsIdTransferLimitsTransferLimitIdError.Response,
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
    /// <exception cref="ApiException{TError}"> of <see cref="PostBalancePlatformsIdTransferLimitsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a transfer limit for your balance platform using the unique <c>id</c> of your balance platform.
    /// </remarks>
    public Task<TransferLimit> PostBalancePlatformsIdTransferLimits(PostBalancePlatformsIdTransferLimitsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{id}/transferLimits"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferLimit>(),
            PostBalancePlatformsIdTransferLimitsError.Response,
            [],
            requestOptions,
            cancellationToken);
}
