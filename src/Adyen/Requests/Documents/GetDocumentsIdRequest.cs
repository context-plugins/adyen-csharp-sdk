namespace Adyen.Requests.Documents;

/// <summary>
/// The inputs of the GetDocumentsId operation.
/// </summary>
public sealed record GetDocumentsIdRequest
{
    /// <summary>
    /// The unique identifier of the document.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Do not load document content while fetching the document.
    /// </summary>
    public bool? SkipContent { get; init; }
}
