using Adyen.Models;

namespace Adyen.Requests.TerminalsTerminalLevel;

/// <summary>
/// The inputs of the PostTerminalsTerminalIdReassign operation.
/// </summary>
public sealed record PostTerminalsTerminalIdReassignRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }

    public TerminalReassignmentRequest? Body { get; init; }
}
