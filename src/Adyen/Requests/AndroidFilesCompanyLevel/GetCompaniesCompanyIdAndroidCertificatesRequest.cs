namespace Adyen.Requests.AndroidFilesCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdAndroidCertificates operation.
/// </summary>
public sealed record GetCompaniesCompanyIdAndroidCertificatesRequest
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
    /// The number of items to have on a page, maximum 100. The default is 20 items on a page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// The name of the certificate.
    /// </summary>
    public string? CertificateName { get; init; }
}
