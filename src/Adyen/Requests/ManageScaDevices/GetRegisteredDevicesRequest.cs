namespace Adyen.Requests.ManageScaDevices;

/// <summary>
/// The inputs of the GetRegisteredDevices operation.
/// </summary>
public sealed record GetRegisteredDevicesRequest
{
    /// <summary>
    /// The unique identifier of a payment instrument. It limits the returned list to SCA devices associated to this payment instrument.
    /// </summary>
    public required string PaymentInstrumentId { get; init; }

    /// <summary>
    /// The index of the page to retrieve. The index of the first page is 0 (zero).
    /// <para>
    /// Default: 0.
    /// </para>
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// The number of items to have on a page.
    /// <para>
    /// Default: 20. Maximum: 100.
    /// </para>
    /// </summary>
    public int? PageSize { get; init; }
}
