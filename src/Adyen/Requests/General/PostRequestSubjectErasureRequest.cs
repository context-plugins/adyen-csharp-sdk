using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostRequestSubjectErasure operation.
/// </summary>
public sealed record PostRequestSubjectErasureRequest
{
    public SubjectErasureByPspReferenceRequest? Body { get; init; }
}
