using Adyen.Models;

namespace Adyen.Requests.Verification;

/// <summary>
/// The inputs of the PostDeleteLegalArrangements operation.
/// </summary>
public sealed record PostDeleteLegalArrangementsRequest
{
    public DeleteLegalArrangementRequest? Body { get; init; }
}
