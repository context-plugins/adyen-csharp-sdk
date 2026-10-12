namespace Adyen.Requests.ManageScaDevices;

/// <summary>
/// The inputs of the DeleteRegisteredDevicesId operation.
/// </summary>
public sealed record DeleteRegisteredDevicesIdRequest
{
    /// <summary>
    /// The unique identifier of the SCA device.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument linked to the SCA device.
    /// </summary>
    public required string PaymentInstrumentId { get; init; }
}
