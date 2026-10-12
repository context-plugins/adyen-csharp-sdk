using Adyen.Models;

namespace Adyen.Requests.ManageCardPin;

/// <summary>
/// The inputs of the PostPinsChange operation.
/// </summary>
public sealed record PostPinsChangeRequest
{
    public PinChangeRequest? Body { get; init; }
}
