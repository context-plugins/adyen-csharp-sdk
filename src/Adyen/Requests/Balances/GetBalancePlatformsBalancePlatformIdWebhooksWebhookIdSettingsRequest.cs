namespace Adyen.Requests.Balances;

/// <summary>
/// The inputs of the GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings operation.
/// </summary>
public sealed record GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    public required string BalancePlatformId { get; init; }

    /// <summary>
    /// The unique identifier of the balance webhook.
    /// </summary>
    public required string WebhookId { get; init; }
}
