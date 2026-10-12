namespace Adyen.Requests.Platform;

/// <summary>
/// The inputs of the GetBalancePlatformsId operation.
/// </summary>
public sealed record GetBalancePlatformsIdRequest
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    public required string Id { get; init; }
}
