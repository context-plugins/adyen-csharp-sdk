using Adyen.Models;

namespace Adyen.Requests.Documents;

/// <summary>
/// The inputs of the PatchDocumentsId operation.
/// </summary>
public sealed record PatchDocumentsIdRequest
{
    /// <summary>
    /// The unique identifier of the document to be updated.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Use the requested verification code 0_0001 to resolve any suberrors associated with the document. Requested verification codes can only be used in your test environment.
    /// </summary>
    public string? XRequestedVerificationCode { get; init; }

    public Document? Body { get; init; }
}
