namespace Adyen.Requests.BusinessLinesApi;

/// <summary>
/// The inputs of the DeleteBusinessLinesId operation.
/// </summary>
public sealed record DeleteBusinessLinesIdRequest
{
    /// <summary>
    /// The unique identifier of the business line to be deleted.
    /// </summary>
    public required string Id { get; init; }
}
