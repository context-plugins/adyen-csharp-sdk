namespace Adyen.Requests.Transfers;

/// <summary>
/// The inputs of the GetTransfersId operation.
/// </summary>
public sealed record GetTransfersIdRequest
{
    /// <summary>
    /// Unique identifier of the transfer.
    /// </summary>
    public required string Id { get; init; }
}
