using Adyen.Models;

namespace Adyen.Requests.Orders;

/// <summary>
/// The inputs of the PostPaymentMethodsBalance operation.
/// </summary>
public sealed record PostPaymentMethodsBalanceRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public BalanceCheckRequest? Body { get; init; }
}
