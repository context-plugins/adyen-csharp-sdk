namespace Adyen.Requests.Platform;

/// <summary>
/// The inputs of the GetBalancePlatformsIdTransactionRules operation.
/// </summary>
public sealed record GetBalancePlatformsIdTransactionRulesRequest
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    public required string Id { get; init; }
}
