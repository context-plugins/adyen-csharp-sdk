using Adyen.Models;

namespace Adyen.Requests.TerminalSettingsTerminalLevel;

/// <summary>
/// The inputs of the PatchTerminalsTerminalIdTerminalSettings operation.
/// </summary>
public sealed record PatchTerminalsTerminalIdTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }

    public TerminalSettings? Body { get; init; }
}
