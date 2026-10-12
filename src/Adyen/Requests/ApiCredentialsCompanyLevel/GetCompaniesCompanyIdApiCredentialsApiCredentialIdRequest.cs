namespace Adyen.Requests.ApiCredentialsCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdApiCredentialsApiCredentialId operation.
/// </summary>
public sealed record GetCompaniesCompanyIdApiCredentialsApiCredentialIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }
}
