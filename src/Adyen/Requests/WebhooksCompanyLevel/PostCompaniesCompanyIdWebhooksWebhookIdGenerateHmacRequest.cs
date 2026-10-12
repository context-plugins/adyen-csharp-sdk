namespace Adyen.Requests.WebhooksCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmac operation.
/// </summary>
public sealed record PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }
}
