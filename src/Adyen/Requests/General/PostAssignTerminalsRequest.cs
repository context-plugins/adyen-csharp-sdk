using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostAssignTerminals operation.
/// </summary>
public sealed record PostAssignTerminalsRequest
{
    public AssignTerminalsRequest? Body { get; init; }
}
