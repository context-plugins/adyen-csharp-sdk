using Adyen.Models.Enums;

namespace Adyen.Requests.DonationCampaigns;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatus operation.
/// </summary>
public sealed record PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the donation campaign to activate or end.
    /// </summary>
    public required string DonationCampaignId { get; init; }

    /// <summary>
    /// The desired status change. Possible values: <b>activate</b> or <b>end</b>.
    /// </summary>
    public required CampaignStatusTransition Status { get; init; }
}
