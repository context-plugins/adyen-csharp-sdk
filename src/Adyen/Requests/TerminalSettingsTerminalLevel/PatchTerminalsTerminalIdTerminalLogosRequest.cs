using Adyen.Models;

namespace Adyen.Requests.TerminalSettingsTerminalLevel;

/// <summary>
/// The inputs of the PatchTerminalsTerminalIdTerminalLogos operation.
/// </summary>
public sealed record PatchTerminalsTerminalIdTerminalLogosRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }

    public Logo? Body { get; init; }
}
