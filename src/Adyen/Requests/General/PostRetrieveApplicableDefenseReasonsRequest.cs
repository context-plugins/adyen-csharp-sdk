using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostRetrieveApplicableDefenseReasons operation.
/// </summary>
public sealed record PostRetrieveApplicableDefenseReasonsRequest
{
    public DefenseReasonsRequest? Body { get; init; }
}
