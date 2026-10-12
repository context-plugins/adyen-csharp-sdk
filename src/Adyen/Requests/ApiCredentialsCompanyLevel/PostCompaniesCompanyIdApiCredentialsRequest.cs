using Adyen.Models;

namespace Adyen.Requests.ApiCredentialsCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdApiCredentials operation.
/// </summary>
public sealed record PostCompaniesCompanyIdApiCredentialsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public CreateCompanyApiCredentialRequest? Body { get; init; }
}
