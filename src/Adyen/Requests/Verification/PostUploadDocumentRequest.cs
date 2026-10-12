using Adyen.Models;

namespace Adyen.Requests.Verification;

/// <summary>
/// The inputs of the PostUploadDocument operation.
/// </summary>
public sealed record PostUploadDocumentRequest
{
    public UploadDocumentRequest? Body { get; init; }
}
