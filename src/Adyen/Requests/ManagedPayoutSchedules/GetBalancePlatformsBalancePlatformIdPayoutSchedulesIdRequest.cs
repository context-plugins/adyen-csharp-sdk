namespace Adyen.Requests.ManagedPayoutSchedules;

/// <summary>
/// The inputs of the GetBalancePlatformsBalancePlatformIdPayoutSchedulesId operation.
/// </summary>
public sealed record GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdRequest
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    public required string BalancePlatformId { get; init; }

    /// <summary>
    /// The unique identifier of the payout configuration for your balance platform.
    /// </summary>
    public required string Id { get; init; }
}
