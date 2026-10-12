using Adyen.Models;

namespace Adyen.Requests.ManageCardPin;

/// <summary>
/// The inputs of the PostPinsReveal operation.
/// </summary>
public sealed record PostPinsRevealRequest
{
    public RevealPinRequest? Body { get; init; }
}
