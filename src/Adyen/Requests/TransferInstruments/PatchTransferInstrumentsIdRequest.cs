using Adyen.Models;

namespace Adyen.Requests.TransferInstruments;

/// <summary>
/// The inputs of the PatchTransferInstrumentsId operation.
/// </summary>
public sealed record PatchTransferInstrumentsIdRequest
{
    /// <summary>
    /// The unique identifier of the transfer instrument.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Use the requested verification code 0_0001 to resolve any suberrors associated with the transfer instrument. Requested verification codes can only be used in your test environment.
    /// </summary>
    public string? XRequestedVerificationCode { get; init; }

    public TransferInstrumentInfo? Body { get; init; }
}
