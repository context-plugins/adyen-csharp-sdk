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
using Adyen.Requests.RaiseDisputes;

namespace Adyen.Api;

public sealed class RaiseDisputes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal RaiseDisputes(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Get a list of raised disputes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DisputeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDisputesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of raised disputes that match the query parameters.
    /// <para>
    /// This endpoint supports cursor-based pagination. The response returns the first page of results, and returns links to the next page when applicable. You can use the links to page through the results. The response also returns links to the previous page when applicable.
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<IReadOnlyList<DisputeResponse>>> GetDisputes(GetDisputesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default23("/disputes"),
            [],
            [
                new Param("status", request.Status),
                new Param("paymentInstrument", request.PaymentInstrument),
                new Param("createdSince", request.CreatedSince),
                new Param("createdUntil", request.CreatedUntil),
                new Param("offset", request.Offset),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<IReadOnlyList<DisputeResponse>>>(),
            GetDisputesError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get dispute by ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisputeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDisputesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a raised dispute by ID.
    /// </remarks>
    public Task<DisputeResponse> GetDisputesId(GetDisputesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default23("/disputes/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DisputeResponse>(),
            GetDisputesIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a raised dispute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisputeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchDisputesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update information related to a raised dispute, or change a dispute's status from <b>draft</b> to <b>submitted</b> or <b>closed</b>.
    /// <para>
    /// <b>Note:</b> Changing the status of a dispute to <b>submitted</b> or <b>closed</b> is a final action. You cannot make updates to a <b>submitted</b> or <b>closed</b> dispute. Make sure to upload all supporting attachments using the <c>POST /disputes/{id}/attachments</c> endpoint before you submit a dispute. When you update a dispute to <b>submitted</b>, Adyen sends the raised dispute to the card scheme for review and acquirer defense. When you update a raised dispute to <b>closed</b>, Adyen closes the dispute, and the dispute is no longer eligible for review by the card scheme.
    /// </para>
    /// </remarks>
    public Task<DisputeResponse> PatchDisputesId(PatchDisputesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default23("/disputes/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DisputeResponse>(),
            PatchDisputesIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Raise a dispute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisputeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDisputesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Raise a dispute for an underlying transaction, providing a dispute type and the amount you want to dispute.
    /// <para>
    /// Raising a dispute returns a dispute ID, which you can use to update details about the dispute, provide supporting documentation, close the dispute, or submit the dispute for a chargeback. You can also use the dispute ID to view the status of the dispute.
    /// </para>
    /// </remarks>
    public Task<DisputeResponse> PostDisputes(PostDisputesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default23("/disputes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DisputeResponse>(),
            PostDisputesError.Response,
            [],
            requestOptions,
            cancellationToken);
}
