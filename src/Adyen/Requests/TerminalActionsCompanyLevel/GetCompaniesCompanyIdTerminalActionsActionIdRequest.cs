namespace Adyen.Requests.TerminalActionsCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdTerminalActionsActionId operation.
/// </summary>
public sealed record GetCompaniesCompanyIdTerminalActionsActionIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the terminal action.
    /// </summary>
    public required string ActionId { get; init; }
}
