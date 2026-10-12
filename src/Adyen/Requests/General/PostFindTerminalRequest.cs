using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostFindTerminal operation.
/// </summary>
public sealed record PostFindTerminalRequest
{
    public FindTerminalRequest? Body { get; init; }
}
