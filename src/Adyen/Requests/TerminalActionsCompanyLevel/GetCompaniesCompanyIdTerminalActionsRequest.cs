namespace Adyen.Requests.TerminalActionsCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdTerminalActions operation.
/// </summary>
public sealed record GetCompaniesCompanyIdTerminalActionsRequest
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
    /// Returns terminal actions with the specified status.
    /// Allowed values: <b>pending</b>, <b>successful</b>, <b>failed</b>, <b>cancelled</b>, <b>tryLater</b>.
    /// </summary>
    public string? Status { get; init; }

    /// <summary>
    /// Returns terminal actions of the specified type.
    /// Allowed values: <b>InstallAndroidApp</b>, <b>UninstallAndroidApp</b>, <b>InstallAndroidCertificate</b>, <b>UninstallAndroidCertificate</b>.
    /// </summary>
    public string? Type { get; init; }
}
