namespace Adyen.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdTerminalModels operation.
/// </summary>
public sealed record GetCompaniesCompanyIdTerminalModelsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }
}
