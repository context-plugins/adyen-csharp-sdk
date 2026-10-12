namespace Adyen.Requests.DisputeAttachments;

/// <summary>
/// The inputs of the GetDisputesDisputeIdAttachmentsAttachmentId operation.
/// </summary>
public sealed record GetDisputesDisputeIdAttachmentsAttachmentIdRequest
{
    /// <summary>
    /// The unique identifier of the raised dispute.
    /// </summary>
    public required string DisputeId { get; init; }

    /// <summary>
    /// The unique identifier of the attachment.
    /// </summary>
    public required string AttachmentId { get; init; }
}
