namespace Adyen.Requests.ApiCredentialsCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdApiCredentials operation.
/// </summary>
public sealed record GetCompaniesCompanyIdApiCredentialsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// The number of items to have on a page, maximum 100. The default is 10 items on a page.
    /// </summary>
    public int? PageSize { get; init; }
}
