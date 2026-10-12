namespace Adyen.Requests.PciQuestionnaires;

/// <summary>
/// The inputs of the GetLegalEntitiesIdPciQuestionnairesPciid operation.
/// </summary>
public sealed record GetLegalEntitiesIdPciQuestionnairesPciidRequest
{
    /// <summary>
    /// The legal entity ID of the individual who signed the PCI questionnaire.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The unique identifier of the signed PCI questionnaire.
    /// </summary>
    public required string Pciid { get; init; }
}
