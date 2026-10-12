using System.ComponentModel.DataAnnotations;

namespace Adyen.Requests.ScaDeviceManagement;

/// <summary>
/// The inputs of the DeleteScaDevicesDeviceId operation.
/// </summary>
public sealed record DeleteScaDevicesDeviceIdRequest
{
    /// <summary>
    /// The unique identifier of the SCA device to delete.
    /// </summary>
    [StringLength(30, MinimumLength = 30)]
    public required string DeviceId { get; init; }
}
