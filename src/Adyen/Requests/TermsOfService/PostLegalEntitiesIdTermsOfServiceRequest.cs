using Adyen.Models;

namespace Adyen.Requests.TermsOfService;

/// <summary>
/// The inputs of the PostLegalEntitiesIdTermsOfService operation.
/// </summary>
public sealed record PostLegalEntitiesIdTermsOfServiceRequest
{
    /// <summary>
    /// The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization.
    /// </summary>
    public required string Id { get; init; }

    public GetTermsOfServiceDocumentRequest? Body { get; init; }
}
