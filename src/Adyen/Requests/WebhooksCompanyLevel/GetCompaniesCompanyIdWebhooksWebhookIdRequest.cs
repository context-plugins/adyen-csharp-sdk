namespace Adyen.Requests.WebhooksCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdWebhooksWebhookId operation.
/// </summary>
public sealed record GetCompaniesCompanyIdWebhooksWebhookIdRequest
{
    /// <summary>
    /// Unique identifier of the <see href="https://docs.adyen.com/account/account-structure#company-account">company account</see>.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }
}
