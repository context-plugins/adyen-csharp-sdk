using Adyen.Models;

namespace Adyen.Requests.DonationCampaigns;

/// <summary>
/// The inputs of the PatchCompaniesCompanyIdCampaignManagementDonationCampaignId operation.
/// </summary>
public sealed record PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the donation campaign to be updated.
    /// </summary>
    public required string DonationCampaignId { get; init; }

    public DonationCampaignUpdate? Body { get; init; }
}
