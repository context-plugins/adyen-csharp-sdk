using Adyen.Models;

namespace Adyen.Requests.Verification;

/// <summary>
/// The inputs of the PostGetUploadedDocuments operation.
/// </summary>
public sealed record PostGetUploadedDocumentsRequest
{
    public GetUploadedDocumentsRequest? Body { get; init; }
}
