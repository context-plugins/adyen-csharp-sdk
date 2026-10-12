using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the EnableServiceRequest operation.
/// </summary>
public sealed record EnableServiceRequestOperationRequest
{
    public EnableServiceRequest? Body { get; init; }
}
