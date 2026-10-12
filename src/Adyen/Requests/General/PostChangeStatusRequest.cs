using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostChangeStatus operation.
/// </summary>
public sealed record PostChangeStatusRequest
{
    public StoredValueStatusChangeRequest? Body { get; init; }
}
