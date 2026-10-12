namespace Adyen.Requests.GrantsApi;

/// <summary>
/// The inputs of the GetGrantsGrantId operation.
/// </summary>
public sealed record GetGrantsGrantIdRequest
{
    /// <summary>
    /// The unique identifier of the grant reference.
    /// </summary>
    public required string GrantId { get; init; }
}
