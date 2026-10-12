namespace Adyen.Requests.ApiKeyCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKey operation.
/// </summary>
public sealed record PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyRequest
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
