namespace Adyen.Requests.TerminalSettingsCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdTerminalSettings operation.
/// </summary>
public sealed record GetCompaniesCompanyIdTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }
}
