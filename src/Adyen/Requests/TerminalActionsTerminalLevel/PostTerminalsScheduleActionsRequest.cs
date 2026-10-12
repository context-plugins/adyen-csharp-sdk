using Adyen.Models;

namespace Adyen.Requests.TerminalActionsTerminalLevel;

/// <summary>
/// The inputs of the PostTerminalsScheduleActions operation.
/// </summary>
public sealed record PostTerminalsScheduleActionsRequest
{
    public ScheduleTerminalActionsRequest? Body { get; init; }
}
