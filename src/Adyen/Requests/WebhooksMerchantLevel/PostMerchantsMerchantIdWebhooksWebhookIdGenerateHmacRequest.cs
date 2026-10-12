namespace Adyen.Requests.WebhooksMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmac operation.
/// </summary>
public sealed record PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public required string WebhookId { get; init; }
}
