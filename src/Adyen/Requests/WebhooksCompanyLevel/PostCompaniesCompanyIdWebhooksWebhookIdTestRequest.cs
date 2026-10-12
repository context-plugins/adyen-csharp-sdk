using Adyen.Models;

namespace Adyen.Requests.WebhooksCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdWebhooksWebhookIdTest operation.
/// </summary>
public sealed record PostCompaniesCompanyIdWebhooksWebhookIdTestRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }

    public TestCompanyWebhookRequest? Body { get; init; }
}
