namespace Adyen.Requests.Documents;

/// <summary>
/// The inputs of the DeleteDocumentsId operation.
/// </summary>
public sealed record DeleteDocumentsIdRequest
{
    /// <summary>
    /// The unique identifier of the document to be deleted.
    /// </summary>
    public required string Id { get; init; }
}
