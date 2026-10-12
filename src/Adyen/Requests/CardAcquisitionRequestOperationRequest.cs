using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the CardAcquisitionRequest operation.
/// </summary>
public sealed record CardAcquisitionRequestOperationRequest
{
    public CardAcquisitionRequest? Body { get; init; }
}
