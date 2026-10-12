using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the DiagnosisRequest operation.
/// </summary>
public sealed record DiagnosisRequestOperationRequest
{
    public DiagnosisRequest? Body { get; init; }
}
