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
    /// <param name="disputeId">The unique identifier of the raised dispute.</param>
    /// <param name="attachmentId">The unique identifier of the attachment.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteDisputesDisputeIdAttachmentsAttachmentIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the attachment from the raised dispute. Adyen may keep this file for compliance purposes.
    /// </remarks>
    public Task DeleteDisputesDisputeIdAttachmentsAttachmentId(string disputeId,
        string attachmentId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default23("/disputes/{disputeId}/attachments/{attachmentId}"),
            [new TemplateParam("disputeId", disputeId), new TemplateParam("attachmentId", attachmentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteDisputesDisputeIdAttachmentsAttachmentIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get all attachments linked to a raised dispute
    /// </summary>
    /// <param name="disputeId">The unique identifier of the raised dispute.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DisputeAttachment"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDisputesDisputeIdAttachmentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a list of attachments associated with a dispute ID.
    /// </remarks>
    public Task<IReadOnlyList<DisputeAttachment>> GetDisputesDisputeIdAttachments(string disputeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default23("/disputes/{disputeId}/attachments"),
            [new TemplateParam("disputeId", disputeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DisputeAttachment>>(),
            GetDisputesDisputeIdAttachmentsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get an attachment
    /// </summary>
    /// <param name="disputeId">The unique identifier of the raised dispute.</param>
    /// <param name="attachmentId">The unique identifier of the attachment.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisputeAttachment"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDisputesDisputeIdAttachmentsAttachmentIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Search for a single attachment, providing the specific dispute ID and attachment ID.
    /// </remarks>
    public Task<DisputeAttachment> GetDisputesDisputeIdAttachmentsAttachmentId(string disputeId,
        string attachmentId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default23("/disputes/{disputeId}/attachments/{attachmentId}"),
            [new TemplateParam("disputeId", disputeId), new TemplateParam("attachmentId", attachmentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DisputeAttachment>(),
            GetDisputesDisputeIdAttachmentsAttachmentIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Add an attachment to a dispute
    /// </summary>
    /// <param name="disputeId">The unique identifier of the raised dispute.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AttachDocumentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDisputesDisputeIdAttachmentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add supporting information as an attachment for the raised dispute. Upload receipts, communication, or any other documentation to support the dispute.
    /// </remarks>
    public Task<AttachDocumentResponse> PostDisputesDisputeIdAttachments(string disputeId,
        DisputeAttachment body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default23("/disputes/{disputeId}/attachments"),
            [new TemplateParam("disputeId", disputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AttachDocumentResponse>(),
            PostDisputesDisputeIdAttachmentsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
