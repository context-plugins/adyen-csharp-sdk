using Adyen.Models;

namespace Adyen.Requests.Transfers;

/// <summary>
/// The inputs of the PostTransfersTransferIdReturns operation.
/// </summary>
public sealed record PostTransfersTransferIdReturnsRequest
{
    /// <summary>
    /// The unique identifier of the transfer to be returned.
    /// </summary>
    public required string TransferId { get; init; }

    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public ReturnTransferRequest? Body { get; init; }
}
