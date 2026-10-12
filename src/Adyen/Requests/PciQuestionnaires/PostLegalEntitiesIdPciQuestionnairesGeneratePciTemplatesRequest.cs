using Adyen.Models;

namespace Adyen.Requests.PciQuestionnaires;

/// <summary>
/// The inputs of the PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplates operation.
/// </summary>
public sealed record PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesRequest
{
    /// <summary>
    /// The unique identifier of the legal entity to get PCI questionnaire information.
    /// </summary>
    public required string Id { get; init; }

    public GeneratePciDescriptionRequest? Body { get; init; }
}
