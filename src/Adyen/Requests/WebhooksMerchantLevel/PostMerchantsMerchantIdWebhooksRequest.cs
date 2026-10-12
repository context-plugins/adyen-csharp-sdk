using Adyen.Models;

namespace Adyen.Requests.WebhooksMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdWebhooks operation.
/// </summary>
public sealed record PostMerchantsMerchantIdWebhooksRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public CreateMerchantWebhookRequest? Body { get; init; }
}
