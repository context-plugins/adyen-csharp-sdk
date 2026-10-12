namespace Adyen.Requests.AndroidFilesCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdAndroidApps operation.
/// </summary>
public sealed record PostCompaniesCompanyIdAndroidAppsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }
}
