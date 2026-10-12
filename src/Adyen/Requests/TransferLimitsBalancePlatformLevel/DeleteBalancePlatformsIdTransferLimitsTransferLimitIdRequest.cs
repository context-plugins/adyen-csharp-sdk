namespace Adyen.Requests.TransferLimitsBalancePlatformLevel;

/// <summary>
/// The inputs of the DeleteBalancePlatformsIdTransferLimitsTransferLimitId operation.
/// </summary>
public sealed record DeleteBalancePlatformsIdTransferLimitsTransferLimitIdRequest
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The unique identifier of the transfer limit.
    /// </summary>
    public required string TransferLimitId { get; init; }
}
