using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostDeleteDisputeDefenseDocument operation.
/// </summary>
public sealed record PostDeleteDisputeDefenseDocumentRequest
{
    public DeleteDefenseDocumentRequest? Body { get; init; }
}
