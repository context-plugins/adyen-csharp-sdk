using Adyen.Models;

namespace Adyen.Requests.Modifications;

/// <summary>
/// The inputs of the PostTechnicalCancel operation.
/// </summary>
public sealed record PostTechnicalCancelRequest
{
    public TechnicalCancelRequest? Body { get; init; }
}
