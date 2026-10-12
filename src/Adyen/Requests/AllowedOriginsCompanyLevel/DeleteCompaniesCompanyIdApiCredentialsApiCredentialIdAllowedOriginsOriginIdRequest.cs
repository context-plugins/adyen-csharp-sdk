namespace Adyen.Requests.AllowedOriginsCompanyLevel;

/// <summary>
/// The inputs of the DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId operation.
/// </summary>
public sealed record DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }

    /// <summary>
    /// Unique identifier of the allowed origin.
    /// </summary>
    public required string OriginId { get; init; }
}
