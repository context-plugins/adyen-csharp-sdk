namespace Adyen.Requests.DisputeAttachments;

/// <summary>
/// The inputs of the GetDisputesDisputeIdAttachments operation.
/// </summary>
public sealed record GetDisputesDisputeIdAttachmentsRequest
{
    /// <summary>
    /// The unique identifier of the raised dispute.
    /// </summary>
    public required string DisputeId { get; init; }
}
