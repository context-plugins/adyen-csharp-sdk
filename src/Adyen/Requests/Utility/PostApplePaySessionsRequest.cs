using Adyen.Models;

namespace Adyen.Requests.Utility;

/// <summary>
/// The inputs of the PostApplePaySessions operation.
/// </summary>
public sealed record PostApplePaySessionsRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public ApplePaySessionRequest? Body { get; init; }
}
