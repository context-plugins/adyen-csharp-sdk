namespace Adyen.Requests.TerminalSettingsTerminalLevel;

/// <summary>
/// The inputs of the GetTerminalsTerminalIdTerminalLogos operation.
/// </summary>
public sealed record GetTerminalsTerminalIdTerminalLogosRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }
}
