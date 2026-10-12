using Adyen.Models;

namespace Adyen.Requests.RecurringApi;

/// <summary>
/// The inputs of the PostForward operation.
/// </summary>
public sealed record PostForwardRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public CheckoutForwardRequest? Body { get; init; }
}
