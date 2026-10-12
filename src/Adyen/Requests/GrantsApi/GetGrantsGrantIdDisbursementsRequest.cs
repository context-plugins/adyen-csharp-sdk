namespace Adyen.Requests.GrantsApi;

/// <summary>
/// The inputs of the GetGrantsGrantIdDisbursements operation.
/// </summary>
public sealed record GetGrantsGrantIdDisbursementsRequest
{
    /// <summary>
    /// The unique identifier of the grant reference.
    /// </summary>
    public required string GrantId { get; init; }
}
