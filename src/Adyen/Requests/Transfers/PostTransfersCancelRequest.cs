using Adyen.Models;

namespace Adyen.Requests.Transfers;

/// <summary>
/// The inputs of the PostTransfersCancel operation.
/// </summary>
public sealed record PostTransfersCancelRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public CancelTransfersRequest? Body { get; init; }
}
