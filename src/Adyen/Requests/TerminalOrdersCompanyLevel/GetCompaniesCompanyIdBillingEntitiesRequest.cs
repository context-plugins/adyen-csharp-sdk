namespace Adyen.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdBillingEntities operation.
/// </summary>
public sealed record GetCompaniesCompanyIdBillingEntitiesRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The name of the billing entity.
    /// </summary>
    public string? Name { get; init; }
}
