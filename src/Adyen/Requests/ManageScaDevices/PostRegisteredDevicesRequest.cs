using Adyen.Models;

namespace Adyen.Requests.ManageScaDevices;

/// <summary>
/// The inputs of the PostRegisteredDevices operation.
/// </summary>
public sealed record PostRegisteredDevicesRequest
{
    public RegisterScaRequest? Body { get; init; }
}
