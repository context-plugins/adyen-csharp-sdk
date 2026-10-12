using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostGetTerminalDetails operation.
/// </summary>
public sealed record PostGetTerminalDetailsRequest
{
    public GetTerminalDetailsRequest? Body { get; init; }
}
