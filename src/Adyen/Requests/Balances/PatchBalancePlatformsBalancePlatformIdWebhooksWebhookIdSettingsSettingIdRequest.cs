using Adyen.Models;

namespace Adyen.Requests.Balances;

/// <summary>
/// The inputs of the PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId operation.
/// </summary>
public sealed record PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest
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

    public required BalanceWebhookSettingInfoUpdate Body { get; init; }
}
