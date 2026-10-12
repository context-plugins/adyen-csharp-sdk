using Adyen.Models;

namespace Adyen.Requests.TermsOfService;

/// <summary>
/// The inputs of the PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentid operation.
/// </summary>
public sealed record PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidRequest
{
    /// <summary>
    /// The unique identifier of the legal entity.
    /// <para>
    /// For sole proprietorships, this is the individual legal entity ID of the owner.
    /// </para>
    /// <para>
    /// For organizations, this is the ID of the organization.
    /// </para>
    /// <para>
    /// For legal representatives of individuals, this is the ID of the individual.
    /// </para>
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The unique identifier of the Terms of Service document.
    /// </summary>
    public required string Termsofservicedocumentid { get; init; }

    public AcceptTermsOfServiceRequest? Body { get; init; }
}
