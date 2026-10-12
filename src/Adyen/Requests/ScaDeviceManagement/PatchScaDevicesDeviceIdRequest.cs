using System.ComponentModel.DataAnnotations;
using Adyen.Models;

namespace Adyen.Requests.ScaDeviceManagement;

/// <summary>
/// The inputs of the PatchScaDevicesDeviceId operation.
/// </summary>
public sealed record PatchScaDevicesDeviceIdRequest
{
    /// <summary>
    /// The unique identifier of the SCA device that you are associating with a resource.
    /// </summary>
    [StringLength(30, MinimumLength = 30)]
    public required string DeviceId { get; init; }

    public FinishScaDeviceRegistrationRequest? Body { get; init; }
}
