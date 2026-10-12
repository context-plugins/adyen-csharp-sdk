using Adyen.Models;

namespace Adyen.Requests.WebhooksMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdWebhooksWebhookIdTest operation.
/// </summary>
public sealed record PostMerchantsMerchantIdWebhooksWebhookIdTestRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }

    public TestWebhookRequest? Body { get; init; }
}
