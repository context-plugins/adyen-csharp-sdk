using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the PrintRequest operation.
/// </summary>
public sealed record PrintRequestOperationRequest
{
    public PrintRequest? Body { get; init; }
}
