namespace Adyen.Requests.RaiseDisputes;

/// <summary>
/// The inputs of the GetDisputesId operation.
/// </summary>
public sealed record GetDisputesIdRequest
{
    /// <summary>
    /// The unique identifier of the raised dispute.
    /// </summary>
    public required string Id { get; init; }
}
