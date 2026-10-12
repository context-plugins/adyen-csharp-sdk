using Adyen.Models;

namespace Adyen.Requests.DonationCampaigns;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdCampaignManagement operation.
/// </summary>
public sealed record PostCompaniesCompanyIdCampaignManagementRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public DonationCampaignRequest? Body { get; init; }
}
