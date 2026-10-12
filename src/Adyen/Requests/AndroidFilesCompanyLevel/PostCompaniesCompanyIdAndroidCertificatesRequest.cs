namespace Adyen.Requests.AndroidFilesCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdAndroidCertificates operation.
/// </summary>
public sealed record PostCompaniesCompanyIdAndroidCertificatesRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }
}
