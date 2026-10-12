namespace Adyen.Requests.TransferInstruments;

/// <summary>
/// The inputs of the DeleteTransferInstrumentsId operation.
/// </summary>
public sealed record DeleteTransferInstrumentsIdRequest
{
    /// <summary>
    /// The unique identifier of the transfer instrument to be deleted.
    /// </summary>
    public required string Id { get; init; }
}
