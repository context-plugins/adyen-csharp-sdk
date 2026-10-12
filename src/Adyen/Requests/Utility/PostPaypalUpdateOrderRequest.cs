using Adyen.Models;

namespace Adyen.Requests.Utility;

/// <summary>
/// The inputs of the PostPaypalUpdateOrder operation.
/// </summary>
public sealed record PostPaypalUpdateOrderRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public PaypalUpdateOrderRequest? Body { get; init; }
}
