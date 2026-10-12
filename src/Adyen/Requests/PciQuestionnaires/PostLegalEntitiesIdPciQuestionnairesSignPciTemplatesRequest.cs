using Adyen.Models;

namespace Adyen.Requests.PciQuestionnaires;

/// <summary>
/// The inputs of the PostLegalEntitiesIdPciQuestionnairesSignPciTemplates operation.
/// </summary>
public sealed record PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesRequest
{
    /// <summary>
    /// The legal entity ID of the user that has a contractual relationship with your platform.
    /// </summary>
    public required string Id { get; init; }

    public PciSigningRequest? Body { get; init; }
}
