namespace Adyen.Requests.Capital;

/// <summary>
/// The inputs of the GetGrantsId operation.
/// </summary>
public sealed record GetGrantsIdRequest
{
    /// <summary>
    /// The unique identifier of the grant.
    /// </summary>
    public required string Id { get; init; }
}
