using Adyen.Models;

namespace Adyen.Requests.AllowedOriginsCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins operation.
/// </summary>
public sealed record PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }

    public AllowedOrigin? Body { get; init; }
}
