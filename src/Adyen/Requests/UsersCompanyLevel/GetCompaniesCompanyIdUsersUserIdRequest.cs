namespace Adyen.Requests.UsersCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdUsersUserId operation.
/// </summary>
public sealed record GetCompaniesCompanyIdUsersUserIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the user.
    /// </summary>
    public required string UserId { get; init; }
}
