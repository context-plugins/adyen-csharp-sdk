using Adyen.Models;

namespace Adyen.Requests.RaiseDisputes;

/// <summary>
/// The inputs of the PatchDisputesId operation.
/// </summary>
public sealed record PatchDisputesIdRequest
{
    /// <summary>
    /// The unique identifier of the raised dispute.
    /// </summary>
    public required string Id { get; init; }

    public PatchableDisputeRequest? Body { get; init; }
}
