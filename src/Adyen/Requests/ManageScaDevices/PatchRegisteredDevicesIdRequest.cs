using Adyen.Models;

namespace Adyen.Requests.ManageScaDevices;

/// <summary>
/// The inputs of the PatchRegisteredDevicesId operation.
/// </summary>
public sealed record PatchRegisteredDevicesIdRequest
{
    /// <summary>
    /// The unique identifier of the SCA device. You obtain this <c>id</c> in the response of a POST&amp;nbsp;<see href="https://docs.adyen.com/api-explorer/balanceplatform/2/post/registeredDevices#responses-200-id">/registeredDevices</see> request.
    /// </summary>
    public required string Id { get; init; }

    public RegisterScaRequest? Body { get; init; }
}
