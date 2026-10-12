namespace Adyen.Requests.GrantOffersApi;

/// <summary>
/// The inputs of the GetGrantOffersGrantOfferId operation.
/// </summary>
public sealed record GetGrantOffersGrantOfferIdRequest
{
    /// <summary>
    /// The unique identifier of the grant offer.
    /// </summary>
    public required string GrantOfferId { get; init; }
}
