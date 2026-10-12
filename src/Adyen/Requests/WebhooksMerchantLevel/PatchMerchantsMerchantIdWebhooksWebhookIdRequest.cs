using Adyen.Models;

namespace Adyen.Requests.WebhooksMerchantLevel;

/// <summary>
/// The inputs of the PatchMerchantsMerchantIdWebhooksWebhookId operation.
/// </summary>
public sealed record PatchMerchantsMerchantIdWebhooksWebhookIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }

    public UpdateMerchantWebhookRequest? Body { get; init; }
}
