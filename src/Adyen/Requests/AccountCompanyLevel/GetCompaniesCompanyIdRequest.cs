namespace Adyen.Requests.AccountCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyId operation.
/// </summary>
public sealed record GetCompaniesCompanyIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }
}
