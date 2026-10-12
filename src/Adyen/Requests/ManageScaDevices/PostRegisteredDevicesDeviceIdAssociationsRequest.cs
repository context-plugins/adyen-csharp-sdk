using Adyen.Models;

namespace Adyen.Requests.ManageScaDevices;

/// <summary>
/// The inputs of the PostRegisteredDevicesDeviceIdAssociations operation.
/// </summary>
public sealed record PostRegisteredDevicesDeviceIdAssociationsRequest
{
    /// <summary>
    /// The unique identifier of the SCA device that you are associating with a resource.
    /// </summary>
    public required string DeviceId { get; init; }

    public AssociationInitiateRequest? Body { get; init; }
}
