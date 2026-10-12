namespace Adyen.Requests.GrantOffersApi;

/// <summary>
/// The inputs of the GetGrantOffers operation.
/// </summary>
public sealed record GetGrantOffersRequest
{
    /// <summary>
    /// The unique identifier of the grant account.
    /// </summary>
    public required string AccountHolderId { get; init; }
}
