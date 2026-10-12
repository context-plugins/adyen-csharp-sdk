namespace Adyen.Requests.TransferInstruments;

/// <summary>
/// The inputs of the GetTransferInstrumentsId operation.
/// </summary>
public sealed record GetTransferInstrumentsIdRequest
{
    /// <summary>
    /// The unique identifier of the transfer instrument.
    /// </summary>
    public required string Id { get; init; }
}
