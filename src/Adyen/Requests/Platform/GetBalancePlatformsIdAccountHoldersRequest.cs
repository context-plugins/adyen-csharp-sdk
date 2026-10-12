namespace Adyen.Requests.Platform;

/// <summary>
/// The inputs of the GetBalancePlatformsIdAccountHolders operation.
/// </summary>
public sealed record GetBalancePlatformsIdAccountHoldersRequest
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The number of items that you want to skip.
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.
    /// </summary>
    public int? Limit { get; init; }
}
