namespace Adyen.Requests.BusinessLinesApi;

/// <summary>
/// The inputs of the GetBusinessLinesId operation.
/// </summary>
public sealed record GetBusinessLinesIdRequest
{
    /// <summary>
    /// The unique identifier of the business line.
    /// </summary>
    public required string Id { get; init; }
}
