namespace Adyen.Requests.Balances;

/// <summary>
/// The inputs of the GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId operation.
/// </summary>
public sealed record GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    public required string BalancePlatformId { get; init; }

    /// <summary>
    /// The unique identifier of the balance webhook.
    /// </summary>
    public required string WebhookId { get; init; }

    /// <summary>
    /// The unique identifier of the balance webhook setting.
    /// </summary>
    public required string SettingId { get; init; }
}
