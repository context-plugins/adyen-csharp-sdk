using Adyen.Models;

namespace Adyen.Requests.PciComplianceQuestionnairePage;

/// <summary>
/// The inputs of the PostGetPciQuestionnaireUrl operation.
/// </summary>
public sealed record PostGetPciQuestionnaireUrlRequest
{
    public GetPciUrlRequest? Body { get; init; }
}
