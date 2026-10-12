using Adyen.Models;

namespace Adyen.Requests.Orders;

/// <summary>
/// The inputs of the PostOrdersCancel operation.
/// </summary>
public sealed record PostOrdersCancelRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public CancelOrderRequest? Body { get; init; }
}
