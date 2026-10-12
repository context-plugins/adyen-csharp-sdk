using Adyen.Models;

namespace Adyen.Requests.DisputeAttachments;

/// <summary>
/// The inputs of the PostDisputesDisputeIdAttachments operation.
/// </summary>
public sealed record PostDisputesDisputeIdAttachmentsRequest
{
    /// <summary>
    /// The unique identifier of the raised dispute.
    /// </summary>
    public required string DisputeId { get; init; }

    public required DisputeAttachment Body { get; init; }
}
