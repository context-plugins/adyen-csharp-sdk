namespace Adyen.Requests.TerminalSettingsTerminalLevel;

/// <summary>
/// The inputs of the GetTerminalsTerminalIdTerminalSettings operation.
/// </summary>
public sealed record GetTerminalsTerminalIdTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }
}
