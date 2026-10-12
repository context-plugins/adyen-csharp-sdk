namespace Adyen.Requests.DonationCampaigns;

/// <summary>
/// The inputs of the DeleteCompaniesCompanyIdCampaignManagementDonationCampaignId operation.
/// </summary>
public sealed record DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the donation campaign to be deleted.
    /// </summary>
    public required string DonationCampaignId { get; init; }
}
