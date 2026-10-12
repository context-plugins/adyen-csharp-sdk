using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the DisplayRequest operation.
/// </summary>
public sealed record DisplayRequestOperationRequest
{
    public DisplayRequest? Body { get; init; }
}
