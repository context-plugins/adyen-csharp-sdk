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
using Adyen.Requests.ScaAssociationManagement;

namespace Adyen.Api;

public sealed class ScaAssociationManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ScaAssociationManagement(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Delete association to devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteScaAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes one or more SCA associations for a device.
    /// </remarks>
    public Task DeleteScaAssociations(DeleteScaAssociationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/scaAssociations"),
            [],
            [],
            [
                new HeaderParam("WWW-Authenticate", request.WwwAuthenticate),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            DeleteScaAssociationsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of devices associated with an entity
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListAssociationsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetScaAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of the SCA devices associated with a specific entity.
    /// </remarks>
    public Task<ListAssociationsResponse> GetScaAssociations(GetScaAssociationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/scaAssociations"),
            [],
            [
                new Param("entityType", request.EntityType),
                new Param("entityId", request.EntityId),
                new Param("pageSize", request.PageSize),
                new Param("pageNumber", request.PageNumber),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListAssociationsResponse>(),
            GetScaAssociationsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Approve a pending approval association
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApproveAssociationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchScaAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Approves a previously created association that is in a pending state.
    /// </remarks>
    public Task<ApproveAssociationResponse> PatchScaAssociations(PatchScaAssociationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/scaAssociations"),
            [],
            [],
            [
                new HeaderParam("WWW-Authenticate", request.WwwAuthenticate),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ApproveAssociationResponse>(),
            PatchScaAssociationsError.Response,
            [],
            requestOptions,
            cancellationToken);
}
