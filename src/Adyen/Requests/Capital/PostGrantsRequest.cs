using Adyen.Models;

namespace Adyen.Requests.Capital;

/// <summary>
/// The inputs of the PostGrants operation.
/// </summary>
public sealed record PostGrantsRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public CapitalGrantInfo? Body { get; init; }
}
