using Adyen.Models;

namespace Adyen.Requests.ScaDeviceManagement;

/// <summary>
/// The inputs of the PostScaDevices operation.
/// </summary>
public sealed record PostScaDevicesRequest
{
    public BeginScaDeviceRegistrationRequest? Body { get; init; }
}
