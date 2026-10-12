namespace Adyen.Requests.AllowedOriginsCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins operation.
/// </summary>
public sealed record GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest
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
