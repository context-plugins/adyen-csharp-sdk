using Adyen.Models;

namespace Adyen.Requests.TransferLimitsBalancePlatformLevel;

/// <summary>
/// The inputs of the PostBalancePlatformsIdTransferLimits operation.
/// </summary>
public sealed record PostBalancePlatformsIdTransferLimitsRequest
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    public required string Id { get; init; }

    public required CreateTransferLimitRequest Body { get; init; }
}
