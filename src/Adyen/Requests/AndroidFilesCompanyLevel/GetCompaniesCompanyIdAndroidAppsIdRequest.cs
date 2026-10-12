namespace Adyen.Requests.AndroidFilesCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdAndroidAppsId operation.
/// </summary>
public sealed record GetCompaniesCompanyIdAndroidAppsIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the app.
    /// </summary>
    public required string Id { get; init; }
}
