using Adyen.Models;

namespace Adyen.Requests.TerminalSettingsCompanyLevel;

/// <summary>
/// The inputs of the PatchCompaniesCompanyIdTerminalLogos operation.
/// </summary>
public sealed record PatchCompaniesCompanyIdTerminalLogosRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.
    /// </summary>
    public required string Model { get; init; }

    public Logo? Body { get; init; }
}
