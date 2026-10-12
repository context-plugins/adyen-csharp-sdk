namespace Adyen.Requests.ClientKeyCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKey operation.
/// </summary>
public sealed record PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyRequest
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
