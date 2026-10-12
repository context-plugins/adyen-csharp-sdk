using Adyen.Models;

namespace Adyen.Requests.Transfers;

/// <summary>
/// The inputs of the PostTransfers operation.
/// </summary>
public sealed record PostTransfersRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// Header for authenticating through SCA
    /// </summary>
    public string? WwwAuthenticate { get; init; }

    public TransferInfo? Body { get; init; }
}
