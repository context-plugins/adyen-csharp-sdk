using Adyen.Models;

namespace Adyen.Requests.TransferInstruments;

/// <summary>
/// The inputs of the PostTransferInstruments operation.
/// </summary>
public sealed record PostTransferInstrumentsRequest
{
    /// <summary>
    /// Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment.
    /// </summary>
    public string? XRequestedVerificationCode { get; init; }

    public TransferInstrumentInfo? Body { get; init; }
}
