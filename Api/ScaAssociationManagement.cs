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
    /// <param name="wwwAuthenticate">The header for authenticating through SCA.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteScaAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes one or more SCA associations for a device.
    /// </remarks>
    public Task DeleteScaAssociations(string wwwAuthenticate,
        RemoveAssociationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/scaAssociations"),
            [],
            [],
            [new HeaderParam("WWW-Authenticate", wwwAuthenticate),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            DeleteScaAssociationsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of devices associated with an entity
    /// </summary>
    /// <param name="entityType">The type of entity you want to retrieve a list of associations for.   Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.</param>
    /// <param name="entityId">The unique identifier of the entity.</param>
    /// <param name="pageSize">The number of items to have on a page.   Default: <b>5</b>.</param>
    /// <param name="pageNumber">The index of the page to retrieve. The index of the first page is <b>0</b> (zero).   Default:  <b>0</b>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListAssociationsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetScaAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of the SCA devices associated with a specific entity.
    /// </remarks>
    public Task<ListAssociationsResponse> GetScaAssociations(ScaEntityType entityType,
        string entityId,
        int pageSize,
        int pageNumber,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/scaAssociations"),
            [],
            [new Param("entityType", entityType),
                new Param("entityId", entityId),
                new Param("pageSize", pageSize),
                new Param("pageNumber", pageNumber)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListAssociationsResponse>(),
            GetScaAssociationsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Approve a pending approval association
    /// </summary>
    /// <param name="wwwAuthenticate">The header for authenticating through SCA.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApproveAssociationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchScaAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Approves a previously created association that is in a pending state.
    /// </remarks>
    public Task<ApproveAssociationResponse> PatchScaAssociations(string wwwAuthenticate,
        ApproveAssociationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/scaAssociations"),
            [],
            [],
            [new HeaderParam("WWW-Authenticate", wwwAuthenticate),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<ApproveAssociationResponse>(),
            PatchScaAssociationsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
