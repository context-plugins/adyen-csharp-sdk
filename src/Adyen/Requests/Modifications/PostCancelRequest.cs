using Adyen.Models;

namespace Adyen.Requests.Modifications;

/// <summary>
/// The inputs of the PostCancel operation.
/// </summary>
public sealed record PostCancelRequest
{
    public CancelRequest? Body { get; init; }
}
