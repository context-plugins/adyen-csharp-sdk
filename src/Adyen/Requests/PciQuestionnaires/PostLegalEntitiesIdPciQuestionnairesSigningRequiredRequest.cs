using Adyen.Models;

namespace Adyen.Requests.PciQuestionnaires;

/// <summary>
/// The inputs of the PostLegalEntitiesIdPciQuestionnairesSigningRequired operation.
/// </summary>
public sealed record PostLegalEntitiesIdPciQuestionnairesSigningRequiredRequest
{
    /// <summary>
    /// The unique identifier of the legal entity to calculate PCI status.
    /// </summary>
    public required string Id { get; init; }

    public CalculatePciStatusRequest? Body { get; init; }
}
