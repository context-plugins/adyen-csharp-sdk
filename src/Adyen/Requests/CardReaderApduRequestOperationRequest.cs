using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the CardReaderApduRequest operation.
/// </summary>
public sealed record CardReaderApduRequestOperationRequest
{
    public CardReaderApduRequest? Body { get; init; }
}
