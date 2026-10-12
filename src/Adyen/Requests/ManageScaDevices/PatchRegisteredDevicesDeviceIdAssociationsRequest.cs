using Adyen.Models;

namespace Adyen.Requests.ManageScaDevices;

/// <summary>
/// The inputs of the PatchRegisteredDevicesDeviceIdAssociations operation.
/// </summary>
public sealed record PatchRegisteredDevicesDeviceIdAssociationsRequest
{
    /// <summary>
    /// The unique identifier of the SCA device that you are associating with a resource.
    /// </summary>
    public required string DeviceId { get; init; }

    public AssociationFinaliseRequest? Body { get; init; }
}
