using Adyen.Models;

namespace Adyen.Requests.Utility;

/// <summary>
/// The inputs of the PostOriginKeys operation.
/// </summary>
public sealed record PostOriginKeysRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public UtilityRequest? Body { get; init; }
}
