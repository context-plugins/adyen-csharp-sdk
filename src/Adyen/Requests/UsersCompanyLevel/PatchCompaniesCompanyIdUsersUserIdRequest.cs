using Adyen.Models;

namespace Adyen.Requests.UsersCompanyLevel;

/// <summary>
/// The inputs of the PatchCompaniesCompanyIdUsersUserId operation.
/// </summary>
public sealed record PatchCompaniesCompanyIdUsersUserIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the user.
    /// </summary>
    public required string UserId { get; init; }

    public UpdateCompanyUserRequest? Body { get; init; }
}
