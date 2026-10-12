using Adyen.Models;

namespace Adyen.Requests.UsersCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdUsers operation.
/// </summary>
public sealed record PostCompaniesCompanyIdUsersRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public CreateCompanyUserRequest? Body { get; init; }
}
