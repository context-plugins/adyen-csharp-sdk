using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostGet3DsAvailability operation.
/// </summary>
public sealed record PostGet3DsAvailabilityRequest
{
    public ThreeDsAvailabilityRequest? Body { get; init; }
}
