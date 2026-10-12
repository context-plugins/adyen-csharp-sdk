using Adyen.Models;

namespace Adyen.Requests.BusinessLinesApi;

/// <summary>
/// The inputs of the PatchBusinessLinesId operation.
/// </summary>
public sealed record PatchBusinessLinesIdRequest
{
    /// <summary>
    /// The unique identifier of the business line.
    /// </summary>
    public required string Id { get; init; }

    public BusinessLineInfoUpdate? Body { get; init; }
}
