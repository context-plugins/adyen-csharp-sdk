using Adyen.Models;

namespace Adyen.Requests.TerminalSettingsCompanyLevel;

/// <summary>
/// The inputs of the PatchCompaniesCompanyIdTerminalSettings operation.
/// </summary>
public sealed record PatchCompaniesCompanyIdTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public TerminalSettings? Body { get; init; }
}
