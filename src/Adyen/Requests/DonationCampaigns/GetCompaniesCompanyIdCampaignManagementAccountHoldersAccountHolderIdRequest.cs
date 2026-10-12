using Adyen.Core.Validation.Attributes;

namespace Adyen.Requests.DonationCampaigns;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderId operation.
/// </summary>
public sealed record GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the account holder.
    /// </summary>
    public required string AccountHolderId { get; init; }

    /// <summary>
    /// The campaign status to return campaigns that match. Allowed values: <b>inactive</b>, <b>active</b>, or <b>ended</b>.
    /// </summary>
    public string? Status { get; init; }

    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    [Minimum(1)]
    public int PageNumber { get; init; } = 1;

    /// <summary>
    /// The number of items to have on a page, maximum 100. The default is 10 items on a page.
    /// </summary>
    [Minimum(1)]
    [Maximum(100)]
    public int PageSize { get; init; } = 10;
}
