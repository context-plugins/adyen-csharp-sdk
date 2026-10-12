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
using Adyen.Requests.DisputeAttachments;

namespace Adyen.Api;

public sealed class DisputeAttachments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal DisputeAttachments(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Delete attachment from a dispute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteDisputesDisputeIdAttachmentsAttachmentIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the attachment from the raised dispute. Adyen may keep this file for compliance purposes.
    /// </remarks>
    public Task DeleteDisputesDisputeIdAttachmentsAttachmentId(DeleteDisputesDisputeIdAttachmentsAttachmentIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default23("/disputes/{disputeId}/attachments/{attachmentId}"),
            [
                new TemplateParam("disputeId", request.DisputeId),
                new TemplateParam("attachmentId", request.AttachmentId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteDisputesDisputeIdAttachmentsAttachmentIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all attachments linked to a raised dispute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DisputeAttachment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDisputesDisputeIdAttachmentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a list of attachments associated with a dispute ID.
    /// </remarks>
    public Task<IReadOnlyList<DisputeAttachment>> GetDisputesDisputeIdAttachments(GetDisputesDisputeIdAttachmentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default23("/disputes/{disputeId}/attachments"),
            [new TemplateParam("disputeId", request.DisputeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DisputeAttachment>>(),
            GetDisputesDisputeIdAttachmentsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get an attachment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisputeAttachment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDisputesDisputeIdAttachmentsAttachmentIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Search for a single attachment, providing the specific dispute ID and attachment ID.
    /// </remarks>
    public Task<DisputeAttachment> GetDisputesDisputeIdAttachmentsAttachmentId(GetDisputesDisputeIdAttachmentsAttachmentIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default23("/disputes/{disputeId}/attachments/{attachmentId}"),
            [
                new TemplateParam("disputeId", request.DisputeId),
                new TemplateParam("attachmentId", request.AttachmentId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DisputeAttachment>(),
            GetDisputesDisputeIdAttachmentsAttachmentIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Add an attachment to a dispute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AttachDocumentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDisputesDisputeIdAttachmentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add supporting information as an attachment for the raised dispute. Upload receipts, communication, or any other documentation to support the dispute.
    /// </remarks>
    public Task<AttachDocumentResponse> PostDisputesDisputeIdAttachments(PostDisputesDisputeIdAttachmentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default23("/disputes/{disputeId}/attachments"),
            [new TemplateParam("disputeId", request.DisputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AttachDocumentResponse>(),
            PostDisputesDisputeIdAttachmentsError.Response,
            [],
            requestOptions,
            cancellationToken);
}
