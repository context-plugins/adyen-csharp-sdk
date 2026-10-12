namespace Adyen.Requests.PciQuestionnaires;

/// <summary>
/// The inputs of the GetLegalEntitiesIdPciQuestionnaires operation.
/// </summary>
public sealed record GetLegalEntitiesIdPciQuestionnairesRequest
{
    /// <summary>
    /// The unique identifier of the legal entity to get PCI questionnaire information.
    /// </summary>
    public required string Id { get; init; }
}
